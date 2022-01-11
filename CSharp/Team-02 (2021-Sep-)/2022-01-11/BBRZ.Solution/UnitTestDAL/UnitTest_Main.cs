using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestDAL
{
  [TestClass]
  public class UnitTest_Main
  {
    [TestMethod]
    public void Test_Region()
    {
      var ds = new BBRZ.DAL.DsCodersBay();

      BBRZ.DAL.Regions.Fill(ds);
      var rc1 = ds.regions.Rows.Count;

      BBRZ.DAL.Countries.Fill(ds);
      var rc2 = ds.countries.Rows.Count;

      Assert.IsTrue((rc1 + rc2) > 0);
    }
  }
}
