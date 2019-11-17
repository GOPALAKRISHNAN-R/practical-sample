using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Simple c# program 
 * @author R.GOPALAKRISHNAN
 * @author gopalakrishnanr94@gmail.com
 * @author www.rgopalakrishnanmca.simplesite.com
 **/


namespace ConsoleApplication3
{
    public class checksum
    {
        public bool isPrime(int x)
        {
            if (x <= 1)
                return false;
            for (int i = 2; i < x / i; i++)
                if ((x % i) == 0)
                    return false;
            return true;
        }
        public int LeastComFact(int a, int b)
        {
            int max;
            if (isPrime(a) || isPrime(b))
                return 1;
            else
            {
                max = a < b ? a : b;
                for (int i = 2; i < max / 2; i++)
                {
                    if (((a % i) == 0) && ((b % i) == 0))
                    {
                        return i;
                    }
                }
                return 1;
            }
        }
         class Program
        {
            static void Main(string[] args)
            {
                checksum obj = new checksum();
                int a, b;
                Console.WriteLine("LCM for 2 numbers");
                Console.WriteLine("-----------------");
                Console.WriteLine("Enter the 2 number:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("LCM for a" + a + "and" + b + "is" + obj.LeastComFact(a, b));
                Console.ReadKey();

            }
        }
    }
}