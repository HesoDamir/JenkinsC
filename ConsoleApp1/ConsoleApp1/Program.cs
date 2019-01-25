using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForJenkins
{
    class Program
    {
        private static void Test(int a)
        {
            for (var i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int a = 10;
            Test(a);
            Console.Read();
        }
    }
}
