using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaiza
{
    class Program
    {
        static void Main()
        {

        }

        static void Template()
        {
            var line1 = Console.ReadLine().Trim();
            var N = int.Parse(line1);
            for (var i = 0; i < N; i++)
            {
                string[] stArrayData = Console.ReadLine().Trim().Split(' ');
                Console.WriteLine("hello = {0} , world = {1}", stArrayData[0], stArrayData[1]);
            }
        }
    }
}
