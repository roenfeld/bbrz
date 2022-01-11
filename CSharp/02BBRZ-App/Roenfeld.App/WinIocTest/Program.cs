using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinIocTest
{
  internal static class Program
  {
    public static IContainer Container {  get; private set; }

    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      CreateContainer();
      var sc = Container.BeginLifetimeScope();
      var f = sc.Resolve<Form1>();
      //sc.InjectUnsetProperties(f);

      Application.Run(f);
    }


    static void CreateContainer()
    {
      var builder = new ContainerBuilder();
      
      var extensions = new string[] { ".exe", ".dll" };

      var dirName = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      var allFile = from x in System.IO.Directory.GetFiles(dirName)
                    let ext = System.IO.Path.GetExtension(x).ToLower()
                    where extensions.Contains(ext)
                    select x;

      foreach (var file in allFile)
      {
        var ass = Assembly.LoadFile(file);
        builder.RegisterAssemblyModules(ass);
      }


      builder.Register(c => new Form1()).PropertiesAutowired();
      builder.Register(c => Program.Container);

      Program.Container = builder.Build();
    }


  }
}
