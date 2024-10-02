using Tyuiu.YakovlevVAa.Sprint1.Task3.V3.Lib;
using System.ComponentModel.DataAnnotations;

namespace Tyuiu.YakovlevVAa.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckParallelepipedVolume()
        {
            DataService ds = new DataService();
            double length = 2.5;
            double width = 2.125;
            double height = 11.615;
            var res = ds.ParallelepipedVolume(length, width, height);
            Assert.AreEqual(61.7046875, res);
        }
    }
}