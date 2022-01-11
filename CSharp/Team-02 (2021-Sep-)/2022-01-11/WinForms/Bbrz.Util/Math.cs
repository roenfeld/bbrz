using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bbrz.Util
{
  public class Math
  {
    /// <summary>
    /// Adds two numbers...
    /// </summary>
    /// <param name="v1"></param>
    /// <param name="v2"></param>
    /// <returns></returns>
    public static decimal Add(decimal v1, decimal v2)
    { 
      return v1 + v2; 
    }

    public static decimal Div(decimal v1, decimal v2)
    {
      if (v2 == 0)
        return 0;

      return v1 / v2;
    }
  }
}
