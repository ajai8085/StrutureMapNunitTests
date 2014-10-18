using LibToTest;
using NUnit.Framework;
using StructureMap.AutoMocking;

namespace StrutureMapNunitTests
{
  [TestFixture]
  public class DefaultTest
  {
    [TestCase]
    public void TestOne()
    {
      var auto = new RhinoAutoMocker<AppServices>();
      var item =auto.ClassUnderTest;
    }
  }
}
