using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestPrj
{
  [TestClass]
  public class UnitTest_BBRZ_Util
  {
    [TestMethod]
    public void Test_Basic()
    {
      decimal v1 = 3;
      decimal v2 = 3;


      var x = Bbrz.Util.Math.Add(v1, v2);
      Assert.IsTrue(x == (v1+v2), $"x = {x}");

      v1 = 10; v2 = 5;
      x = Bbrz.Util.Math.Div(v1, v2);
      Assert.IsTrue(x == (v1/v2), $"x = {x}");

    }


    [TestMethod]
    public void Test_Extended()
    {
      var x = Bbrz.Util.Math.Div(10m, 0);
    }

  }
}
