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

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j=0, k=0;
            Console.WriteLine("Finding odd or even in a array");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.WriteLine("Even number in the array are:");
            for(i=0;i<j;i++)
            {
                Console .WriteLine (arr2[i]);
            }
            Console .WriteLine ("Odd number in an array are:");
            for(i=0;i<k;i++)
            {
                Console .WriteLine (arr3[i]);
            }
            Console.ReadKey();
        }
        
        }
    }
