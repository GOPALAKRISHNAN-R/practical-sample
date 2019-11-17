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

namespace ConsoleApplication10
{
    class Program
    {
        static int add(params int[] allnumber)
        {
            int sum = 0;
            foreach (int n in allnumber)
            {
                sum = sum + n;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum;
            sum = Program.add(1, 2, 3);
            Console.WriteLine("Sum of 1,2,3 is:\t{0}", sum);
            sum = Program.add(3, 5, 2, 6, 2);
            Console.WriteLine("Sum of 3,5,2,6,2 is:\t{0}", sum);
            Console.ReadLine();

        }
    }
}