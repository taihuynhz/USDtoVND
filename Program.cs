using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoVND
{
    class Program
    {
        static void Main(string[] args)
        {
            float USD;
            float exchangeRate = 23000f;

            Console.Write("Nhap vao gia tri USD: ");
            USD = float.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD = " + USD * exchangeRate + " VND");
        }
    }
}
