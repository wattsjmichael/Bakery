using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    public void IsBread_NumberTimesByTwo_True()
    {
      Bread testOrder = new Bread();
      Assert.AreEqual(true, testOrder.IsOrder(6));
    }
  }
}
