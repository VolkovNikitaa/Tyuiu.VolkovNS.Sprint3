using Tyuiu.VolkovNS.Sprint3.Task3.V30.Lib;

namespace Tyuiu.VolkovNS.Sprint3.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int max = 4;
            Assert.AreEqual(max, ds.GetMaxCharCount("fyyklbtyn ygrc vfyyyyh", 'y'));
        }
    }
}
