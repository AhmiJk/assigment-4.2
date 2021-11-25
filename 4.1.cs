using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qs52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 35;
            x = y++ + x++;
            y = ++y + ++x;
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
