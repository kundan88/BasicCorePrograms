using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapTwoNumber
    {
        public static void SwapNumbers()
        {
            int x, y, temp;
     
                Console.Write("\nInput the First Number : ");
                x = int.Parse(Console.ReadLine())
                    ;
                Console.Write("\nInput the Second Number : ");
                y = int.Parse(Console.ReadLine());

                temp = x;
                x = y;
                y = temp;

                Console.Write("\nAfter Swapping : ");
                Console.Write("\nFirst Number : " + x);
                Console.Write("\nSecond Number : " + y);
                Console.Read();
            }


        }
	}
