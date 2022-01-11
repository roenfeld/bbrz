using Autofac;
using Autofac.Features.OwnedInstances;
using Roenfeld.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Roenfeld.Dependency
{
  public class ServiceProvider : Roenfeld.Interfaces.IServiceProvider
  {
    internal static IContainer _container;

    public ServiceProvider(IContainer container)
    {
      _container = container;
    }


    public T Resolve<T>()
    {
      return ServiceProvider.GetType<T>();
    }


    public T Resolve<T>(string serviceName)
    {
      throw new NotImplementedException();
    }


    public static T GetType<T>()
    {
      using (var scope = _container.BeginLifetimeScope())
      {
        var name = typeof(T).Name;
        try
        {
          return scope.Resolve<T>();
        }
        catch (Exception ex)
        {
          Trace.TraceError(ex.Message);
        }
        return default;
      }
    }
  }


  public class Container
  {

    public static IContainer Instance { get; protected set; }


    public static void Create()
    {
      Create(null);
    }


    public static void Create(IEnumerable<Type> typesToRegister)
    {
      var msg = $"{typeof(Container).FullName}:{nameof(Create)}()";
      Trace.WriteLine(msg);

      var builder = new ContainerBuilder();

      // Logger


      // DAL
      builder.RegisterType<BaseDAL>().AsSelf();


      // from files...
      RegisterTypesFromAssemblies(builder);



      // ServiceProvider is IMPORTANT, as this is a key feature...
      //var sp = new ServiceProvider(Instance);
      //builder.RegisterInstance(sp).As<Roenfeld.Interfaces.IServiceProvider>().ExternallyOwned();
      builder.Register(ctx =>
      {
        var inst = Container.Instance;
        var sp = new ServiceProvider(inst);
        return sp;
      }).As<Roenfeld.Interfaces.IServiceProvider>();
      Trace.WriteLine($"class {nameof(ServiceProvider)} registered.");


      // given types...
      Trace.WriteLine($"registering {nameof(typesToRegister)} (=method param)...");
      if (typesToRegister != null)
      {
        foreach (var type in typesToRegister)
        {
          if (!type.IsAbstract)
          {
            builder.RegisterType(type).AsSelf().PropertiesAutowired().ExternallyOwned();
            Trace.WriteLine($"class {type.Name} registered.");
          }
        }
      }

      Container.Instance = builder.Build();
      ServiceProvider._container = Container.Instance;

      Trace.WriteLine($"{msg} DONE.");
    }



    protected static void RegisterTypesFromAssemblies(ContainerBuilder builder)
    {
      if (builder == null)
      {
        Trace.WriteLine($"{nameof(RegisterTypesFromAssemblies)}(): builder is null.");
        return;
      }

      var extensions = new string[] { ".exe", ".dll" };

      var dirName = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

      //Trace.WriteLine($"{nameof(RegisterTypesFromAssemblies)}(): getting files from directory {dirName}...");
      var allFile = from x in System.IO.Directory.GetFiles(dirName)
                    let ext = System.IO.Path.GetExtension(x).ToLower()
                    where extensions.Contains(ext)
                    select x;

      Trace.Indent();
      foreach (var file in allFile)
      {
        var ass = Assembly.LoadFile(file);

        Trace.WriteLine($"{nameof(RegisterTypesFromAssemblies)}(): getting types from file {file}...");
        var someTypes = from x in ass.GetExportedTypes()
                        where x.IsAbstract == false
                        where x.IsSubclassOf(typeof(System.Windows.Forms.UserControl))
                        select x;

        foreach (var type in someTypes)
        {
          Trace.WriteLine($"{nameof(RegisterTypesFromAssemblies)}(): registering type {type.FullName}...");
          builder.RegisterType(type).AsSelf().PropertiesAutowired().ExternallyOwned();
          Trace.WriteLine($"{nameof(RegisterTypesFromAssemblies)}(): {type.FullName} registered.");
        }

        Trace.WriteLine($"{nameof(RegisterTypesFromAssemblies)}(): registering assembly {ass.GetName()}...");
        builder.RegisterAssemblyModules(ass);
        Trace.WriteLine($"{nameof(RegisterTypesFromAssemblies)}(): {ass.GetName()} registered.");
      }
      Trace.Unindent();
    }

  }
}
