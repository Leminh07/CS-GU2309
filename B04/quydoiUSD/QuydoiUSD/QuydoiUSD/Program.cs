using System;

namespace toantu
{
    class Program
    {
        static void Main(string[] args)
        {
            int USD;
           
            Console.WriteLine("Vui long nhap USD: ");
            USD = int.Parse(Console.ReadLine());
            int VND = USD * 23000;
            Console.WriteLine(VND);

        }
    }
}