using Tyuiu.YakovlevVAa.Sprint1.Task5.V2.Lib;
namespace Tyuiu.YakovlevVAa.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFahrenheitTo—elsius()
        {
            DataService ds = new DataService();
            double temp = 38;
            var res = ds.FahrenheitTo—elsius(temp);
            Assert.AreEqual(3, res);

        }
    }
}