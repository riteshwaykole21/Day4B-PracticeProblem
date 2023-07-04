using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProblem
{
    public class MaxMin
    {
        public void Number()
        {
            int[] Arr = {12,28,39,32,65,2,55,1};
            for(int i = 0; i < Arr.Length; i++)
            {
                for(int j = i + 1 ; j < Arr.Length; j++)
                {
                    if(Arr[i] > Arr[j])
                    {
                        int Temp = Arr[i];
                        Arr[i] = Arr[j];    
                        Arr[j] = Temp;
                    }
                }
            }
            Console.WriteLine($"The Minimum Value Of Array is {Arr[0]}");
            Console.WriteLine($"The Maximum Value Of Array is {Arr[Arr.Length - 1]}");
        }
    }
}
