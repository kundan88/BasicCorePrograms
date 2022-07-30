using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOddNumber
    {
        public static void EvenOddNum()
        {
            int x;
            Console.WriteLine("Enter a any No. ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }


        }
    }
}
