using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_den_1_milyona_kadar_sayiları_7_ye_bolme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;

            //
            Console.WriteLine("Lütfen 1000000 Kadar Bir Sayı Giriniz");
            Console.WriteLine(ConvertToInt32(Console.ReadLine());
            //

            //yukardaki iki satır neden var, olmalı mı???

            for (int i = 1; i <= 1000000; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                    sayac++;
                }
            }
            Console.WriteLine("7'ye tam bölünen sayı adeti={0}", sayac);
            Console.ReadKey();
        }
    }
}
