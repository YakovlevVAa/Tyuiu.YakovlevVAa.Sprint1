using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.YakovlevVAa.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            if (value != "0")
                return uint.TryParse(value, out _);
            else
                return false;
;        }
    }
}
