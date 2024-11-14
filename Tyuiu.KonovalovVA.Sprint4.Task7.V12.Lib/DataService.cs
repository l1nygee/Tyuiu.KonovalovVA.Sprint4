using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KonovalovVA.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] ar = new int[n, m];
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ar[i,j] = int.Parse(value[i*n+j].ToString());
                    if (ar[i, j] % 2 != 0) res += ar[i, j];
                }
            }
            return res;
        }
    }
}
