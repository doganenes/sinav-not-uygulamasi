using System;

namespace Not_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            string ad, soyad, bolum, ders;

            int sinav1, sinav2, sinav3, ort;

            //String Değişkenlerin Atamaları
            ad = "Enes";
            soyad = "Doğan";
            bolum = "Bilgisayar Mühendisliği";
            ders = "Algoritma Programlama";

            //Int Değişkenlerin Atamaları

            sinav1 = 85;
            sinav2 = 79;
            sinav3 = 80;
            ort = (sinav1 + sinav2 + sinav3) / 3;
            //Console.WriteLine(ort);

            Console.WriteLine("***** Öğrenci Bilgi Ekranı *****");
            Console.WriteLine();

            Console.WriteLine("Öğrenci Adı Soyadı: " + ad + " " + soyad);
            Console.WriteLine("Bölüm: " + bolum);
            Console.WriteLine("Ders: " + ders);
            Console.WriteLine();
            Console.WriteLine("Sınav 1: " + sinav1);
            Console.WriteLine("Sınav 2: " + sinav2);
            Console.WriteLine("Sınav 3: " + sinav3);

            Console.WriteLine("Ortalamanız: " + ort);
            Console.WriteLine();
            Console.WriteLine("***** Öğrenci Bilgi Ekranı *****");
            Console.Read();
        }
    }
}
