using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void Test_200_100_Bmi25()
    {
      var b = new BmiRechnerV1.BmiCalc();

      b.HeightCm = 200;
      b.WeightKg = 100;
      
      Assert.AreEqual(b.BMI, 24, "expected 25!");
    }
  }
}
