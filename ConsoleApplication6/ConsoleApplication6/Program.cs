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

namespace ConsoleApplication6
{
    class ex5
    {
        public void SubString()
        {
            Console.WriteLine("Enter the String:");
            String str = Console.ReadLine();
            Console.WriteLine("Enter the searching String:");
            String str2 = Console.ReadLine();
            bool m = str.Contains(str2);
            if (m)
            {
                Console.WriteLine("The searching String exit in the string");
            }
            else
            {
                Console.WriteLine("The searching string does not exit");
            }
        }
        public void Extr()
{
    char[] arr1;
    int pos,l,c=0;
    Console.WriteLine("Enter the String:");
    String str=Console.ReadLine();
    int ln=str.Length;
    arr1=str.ToCharArray(0,ln);
    Console.WriteLine("Enter the extracting position:");
    pos=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Length of extracing string:");
    l=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Extracting String is:");
    while(c<l)
{
    Console.Write(arr1[pos+c-1]);
    c++;
}
}
    }
    class Program
    {
        static void Main(string[] args)
        {
            ex5 e = new ex5();
            int opt;
            Console.WriteLine("The String Manipulation");
            Console.WriteLine("----------------------");
            Console.WriteLine("\n1.SUBSTRING \n 2.EXTRACT STRING \n 3.EXIT");
            do
            {
                Console.WriteLine("Enter the option:");
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        e.SubString();
                        break;
                    case 2:
                        e.Extr();
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                }
            } while (opt != 3);

            Console.ReadKey();
        }
    }
}


