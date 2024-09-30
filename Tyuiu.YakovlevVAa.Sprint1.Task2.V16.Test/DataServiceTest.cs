using Tyuiu.YakovlevVAa.Sprint1.Task2.V16.Lib;
namespace Tyuiu.YakovlevVAa.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 2;
            var res = ds.CalculatePerimetrCircle(value);
            Assert.AreEqual(12.564, res);
        }
    }
}