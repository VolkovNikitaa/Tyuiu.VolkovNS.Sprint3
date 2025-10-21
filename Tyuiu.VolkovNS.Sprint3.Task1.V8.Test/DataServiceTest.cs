using System.Diagnostics.CodeAnalysis;
using Tyuiu.VolkovNS.Sprint3.Task1.V8.Lib;

namespace Tyuiu.VolkovNS.Sprint3.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double sum1 = -302185.684;
            Assert.AreEqual(sum1, ds.GetSumSeries(0.25, 1, 7));
        }
    }
}
