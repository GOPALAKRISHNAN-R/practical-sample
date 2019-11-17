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

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 10;
            int n = 0;
            Console.WriteLine("Exception Handling");
            try
            {
                int k = m / n;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught:" + e.Message);
            }
            finally
            {
                Console.WriteLine("Inside division method");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
