using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProblem
{
    public class UniqueElement
    {
        public void Element()
        {
            string str = "ABCDEFAB";
            char[] chars = str.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                bool Duplicate = false;
                for (int j = 0; j < i; j++)
                {
                   if(chars[i] == chars[j])
                   {
                        Duplicate = true;
                        break;
                   }
                }
                if (!Duplicate)
                {
                    Console.WriteLine(chars[i]);
                }
            }
        }
    }
}
