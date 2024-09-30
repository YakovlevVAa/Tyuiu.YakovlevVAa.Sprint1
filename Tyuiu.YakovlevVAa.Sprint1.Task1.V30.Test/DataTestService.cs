using Tyuiu.YakovlevVAa.Sprint1.Task1.V30.Lib;
namespace Tyuiu.YakovlevVAa.Sprint1.Task1.V30.Test
{
    [TestClass]
    public class DataTestService
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.5;
            var res = ds.Calculate(x);
            Assert.AreEqual(2.25, res);
        }
    }
}