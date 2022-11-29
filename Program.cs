using System;
using System.Linq;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.SORU
            Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz.");
            int n = int.Parse(Console.ReadLine());
            int[] sayilar = new int[n]; 
            
            for(int i =0;i<n;i++)
            {
                Console.Write($"{i+1}. Sayıyı Giriniz.");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach(int sayi in sayilar)
            {
                if(sayi%2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }

            //2.SORU

            Console.WriteLine("Lütfen Pozitif 2 Tam Sayı Giriniz.");
            Console.Write("1. Sayıyı Giriniz: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] sayilar = new int[n];
            Console.WriteLine($"{n} Adet Sayı Giriniz.");
            for(int i = 0;i<n;i++)
            {
                
                Console.Write($"{i+1}. Sayıyı Giriniz.");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach(int sayi in sayilar)
            {
                if(sayi%m == 0)
                {
                    Console.WriteLine(sayi);
                }
            }

            //3.SORU

            Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz.");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n} Adet Kelime Giriniz.");
            string[] kelime = new string[n];

            for(int i = 0;i < kelime.Length; i++)
            {
                Console.Write($"{i+1}. Kelimeyi Giriniz: ");
                kelime[i] = Console.ReadLine();
            }

            foreach(string sıra in kelime.Reverse())
            {
                Console.WriteLine(sıra);
            }

            //4.SORU

            Console.Write("Cümle Yazınız: ");
            string sentence = Console.ReadLine();
            sentence = sentence.ToLower();

            string harfler = "abcçdefgğhıijklmnoöprsştuüvyz";

            int harfsayısı = 0;
            for(int i = 0;i<sentence.Length;i++)
            {
                if(harfler.Contains(sentence[i]))
                {
                    harfsayısı++;
                }
            }
            Console.WriteLine("Harf Sayısı: " + harfsayısı);

            string[] kelime = sentence.Split(' ');

            Console.WriteLine("Kelime Sayısı: " + kelime.Length);
            
        }
    }
}
