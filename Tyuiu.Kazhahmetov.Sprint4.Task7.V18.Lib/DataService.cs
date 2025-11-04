using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Kazhahmetov.Sprint4.Task7.V18.Lib
{
    public class DataService : ISprint4Task7V18
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                }
            }

            int res = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        res *= matrix[i, j];
                    }
                }
            }
            return res;

        }
    }
}
