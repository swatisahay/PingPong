using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
namespace PingPong.Tests
{
  [TestClass]
  public class PingTest
  {
    [TestMethod]
    public void IsPingPong_NumberDivByThreeFiveTrue()
  {
    Ping PingPongTest = new Ping();
      Assert.AreEqual(true, PingPongTest.IsPingPong(30));
  }
   }
}
