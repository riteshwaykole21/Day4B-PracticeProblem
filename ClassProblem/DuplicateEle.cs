using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProblem
{
    public class DuplicateEle
    {
        public void Elements()
        {
            string Sen = "ABCDEFGAC";
            char[] Sen2 = Sen.ToCharArray();
            int count = 0;
            for (int i = 0; i < Sen2.Length; i++)
            {  
                for (int j = i + 1; j < Sen2.Length; j++)
                {
                    if (Sen2[i] == Sen2[j])
                    {
                        Console.WriteLine(Sen2[j]);
                        count++;
                    }
                }
                Console.WriteLine(count);
            }

           
        }
    }
}
