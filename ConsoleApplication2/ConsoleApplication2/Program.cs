using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Simple c# program for check given number is prime or not
 * @author R.GOPALAKRISHNAN
 * @author gopalakrishnanr94@gmail.com
 * @author www.rgopalakrishnanmca.simplesite.com
 **/


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,c=0;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                Console.WriteLine(n + "is prime number");
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    int r = n % i;
                    if (r == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                {
                    Console.WriteLine(n + "is prime number");
                }
                else
                {

                    Console.WriteLine(n + "is not prime number");
                }
            }
            Console.ReadKey();
        }
    }
}
