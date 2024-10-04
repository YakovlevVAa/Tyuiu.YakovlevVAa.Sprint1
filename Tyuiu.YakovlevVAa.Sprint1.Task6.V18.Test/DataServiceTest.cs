using Tyuiu.YakovlevVAa.Sprint1.Task6.V18.Lib;
namespace Tyuiu.YakovlevVAa.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckNumber()
        {
            DataService ds = new DataService();
            string value = "0";
            Assert.AreEqual(false, ds.CheckNumber(value));
        }
    }
}