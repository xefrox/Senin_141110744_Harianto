using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_A_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            var query = from i in arr where i % 2==0 select i;
            foreach (int i in query)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=================");
            foreach (int i in arr)
            {
                if(i % 2 == 0 )  {
                Console.WriteLine(i);}
            }
            Console.WriteLine("=================");
            Console.ReadKey();
        }
    }
}
