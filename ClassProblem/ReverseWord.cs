using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProblem
{
    public class ReverseWord
    {
        public void Words()
        {
            string str = "Ritesh waykole";
            char[] Chars = str.ToCharArray();
            for(int i = Chars.Length - 1; i >= 0; i--)
            {
                Console.Write(Chars[i]);
            }
        }
    }
}
