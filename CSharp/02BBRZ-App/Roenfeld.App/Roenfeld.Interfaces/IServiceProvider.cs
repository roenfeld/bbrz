using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roenfeld.Interfaces
{
  public interface IServiceProvider
  {
    T Resolve<T>();
    T Resolve<T>(string serviceName);
  }
}
