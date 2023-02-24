using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic1
{
    public class SOLUTION
    {
        public SOLUTION(int i, int j)
        {
            I = i;
            J = j;

            int n = i;
            int m = j;

            int poznum = 0;
            int[,] b = new int[n, m];

            for (int ii = 0; ii < n; ii++)
            {
                for (int jj = 0; jj < m; jj++)
                {
                    b[ii, jj] = Convert.ToInt32(Math.Sin((ii + jj) / 2));
                    if (b[ii, jj] > 0) poznum += 1;
                }
            }

            Solution(poznum);


            Console.WriteLine("Ответ: число положительных элементов = {0}", poznum);
      
        }

        public int Solution(int poznu) {
            return poznu;
           
        }


        public int I { get; set; }
        public int J { get; set; }


       
    }
}
