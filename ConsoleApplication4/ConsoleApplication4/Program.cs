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

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, cnt = 0;
            Console.WriteLine("Counting no. of duplicate elements in an array");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Enter no. of element to be inserted:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the array elements:");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        cnt++;
                        Console.WriteLine("The duplicate element are:" + arr[i]);
                        break;
                    }
                }
            }
            Console.WriteLine("Array elements are:");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Total no. of duplicate are:" + cnt);
            Console.ReadKey();
        }
    }
}
