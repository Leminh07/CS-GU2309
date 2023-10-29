using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int index;
            Console.WriteLine(index);
            int[] a = new int[i];

            a[0] = 10; a[1] = 4; a[2] = 6; a[3] = 7; a[4] = 8;
            Console.WriteLine(a);

            int[] b = new int[10]; b[0] = a[0]; b[1] = a[1]; b[2] = a[2]; b[3] = index; b[4] = a[3]; b[5] = a[4];
            Console.WriteLine(b);
        }
    }
}
