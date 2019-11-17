using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Simple c# program
 * @author R.GOPALAKRISHNAN
 * @author gopalakrishnanr94@gmail.com
 * @author www.rgopalakrishnanmca.simplesite.com
 **/

namespace ConsoleApplication15
{
    class MyClass
    {
        int x;
        int y;
        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }
        public int Sum()
        {
            return x + y;
        }
        public bool IsBetween(int i)
        {
            if (x < i && i < y)
                return true;
            else return false;
        }
        public void Set(int a, int b)
        {
            x = a;
            y = b;
        }
        public void Set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }
        public void Show()
        {
            Console.WriteLine(" x: {0}, y: {1}", x, y);
        }
    }
    class ReflectDemo
    {
        static void Main(String[] args)
        {
            Type t = typeof(MyClass);
            Console.WriteLine("Analyzing methods in " + t.Name);
            Console.WriteLine();
            Console.WriteLine("Methods supported: ");
            MethodInfo[] mi = t.GetMethods();

            foreach (MethodInfo m in mi)
            {
                Console.Write(" " + m.ReturnType.Name + " " + m.Name + "(");
                ParameterInfo[] pi = m.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length)
                        Console.Write(", ");
                }
                Console.WriteLine(")");
                Console.WriteLine();

            }
            Console.ReadKey();
        }

    }


}