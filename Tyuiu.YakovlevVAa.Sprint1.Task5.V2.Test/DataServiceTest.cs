using Tyuiu.YakovlevVAa.Sprint1.Task5.V2.Lib;
namespace Tyuiu.YakovlevVAa.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFahrenheitToĐelsius()
        {
            DataService ds = new DataService();
            double temp = 38;
            var res = ds.FahrenheitToĐelsius(temp);
            Assert.AreEqual(3, res);

        }
    }
}