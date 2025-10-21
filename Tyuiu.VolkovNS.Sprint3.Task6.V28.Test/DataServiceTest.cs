using Tyuiu.VolkovNS.Sprint3.Task6.V28.Lib;

namespace Tyuiu.VolkovNS.Sprint3.Task6.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 15;
            Assert.AreEqual(n, ds.GetSumTheDivisors(13, 19));
        }
    }
}
