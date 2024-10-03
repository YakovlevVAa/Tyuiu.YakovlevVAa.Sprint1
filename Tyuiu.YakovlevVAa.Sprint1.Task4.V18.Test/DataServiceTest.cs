using Tyuiu.YakovlevVAa.Sprint1.Task4.V18.Lib;
namespace Tyuiu.YakovlevVAa.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x, y;
            x = 1;
            y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}