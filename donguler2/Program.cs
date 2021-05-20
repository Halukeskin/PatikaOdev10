using System;

namespace donguler2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            Console.WriteLine("Bir Harf Giriniz");
            char karakter = 'a';
            while (karakter <= 'z')
            {
                Console.WriteLine(karakter);
                karakter ++;
            }

            string[] arabalar = {"bmw", "ford", "ferrari"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
