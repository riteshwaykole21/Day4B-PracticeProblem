using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProblem
{
    public class ZeroPattern
    {
        public void Pattern()
        {
            for(int i = 1; i <= 7; i++)
            {
                for(int j = 1; j <= 7; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
