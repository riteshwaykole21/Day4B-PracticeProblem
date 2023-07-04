using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProblem
{
    public class SumodArray
    {
        public void Numbers()
        {
            int[] ints = { 10, 20, 30, 40, 50, 60, 70,50 };
            int sum = 0;
            for(int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            Console.WriteLine($"The Sum Of All Array Element Is {sum}");
        }
    }
}
