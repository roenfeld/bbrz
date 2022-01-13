using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DAL_Test
{
  [TestClass]
  public class BasicTests
  {
    [TestMethod]
    public void Regions()
    {
      var ds = new DAL.DsCodersBay();

      DAL.DsCodersBay.FillRegions(ds);
    }

  }
}
