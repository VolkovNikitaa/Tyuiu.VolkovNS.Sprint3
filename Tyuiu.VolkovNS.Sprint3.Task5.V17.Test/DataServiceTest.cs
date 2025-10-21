using Tyuiu.VolkovNS.Sprint3.Task5.V17.Lib;

namespace Tyuiu.VolkovNS.Sprint3.Task5.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double sum = 88.822;
            Assert.AreEqual(sum, ds.GetSumSumSeries(2, 1, 1, 3, 12));
        }
    }
}
