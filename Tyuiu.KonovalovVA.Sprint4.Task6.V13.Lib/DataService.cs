using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KonovalovVA.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            int res = 0;
            foreach (var item in array)
            {
                if (item.Length > 4) res++;
            }
            return res;
        }
    }
}
