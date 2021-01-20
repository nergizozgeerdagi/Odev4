using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Soda", "Su", "Çay", "Kahve"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "Vişne";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);




            List<string> isimler2 = new List<string> { "Soda", "Su", "Çay", "Kahve" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Vişne");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Patates");
            Console.WriteLine(isimler2[5]);

            List<int> sayilar1 = new List<int> { 25, 44, 966, 8585 };
            Console.WriteLine(sayilar1[0]);
            Console.WriteLine(sayilar1[1]);
            Console.WriteLine(sayilar1[2]);
            Console.WriteLine(sayilar1[3]);
            sayilar1.Add(37);
            Console.WriteLine(sayilar1[4]);
            sayilar1.Add(9);
            Console.WriteLine(sayilar1[5]);
            Console.WriteLine(sayilar1[2]);

        }
    }
}
