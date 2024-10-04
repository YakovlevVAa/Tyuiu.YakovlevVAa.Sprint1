using Tyuiu.YakovlevVAa.Sprint1.Task7.V17.Lib;
namespace Tyuiu.YakovlevVAa.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x, y;
            x = 0;
            y = 1;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(-12.656, res);
        }
    }
}