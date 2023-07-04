using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Duplicate element Of An Array");
            Console.WriteLine("2 : Unique Element Of A Array");
            Console.WriteLine("3 : Max And Min");
            Console.WriteLine("4 : Angle Pattern");
            Console.WriteLine("5 : Reverse Word In C#");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    DuplicateEle duplicateEle = new DuplicateEle();
                    duplicateEle.Elements();
                    break;
                case 2:
                    UniqueElement uniqueElement = new UniqueElement();
                    uniqueElement.Element();
                    break;
                case 3:
                    MaxMin maxMin = new MaxMin();
                    maxMin.Number();
                    break;
                case 4:
                    AnglePattern pat = new AnglePattern();
                    pat.Pattern();  
                    break;
                case 5:
                    ReverseWord rev = new ReverseWord();
                    rev.Words();
                    break;
            }
            Console.ReadLine();
        }
    }
}
