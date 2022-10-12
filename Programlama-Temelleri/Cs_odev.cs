
using System;
public class Program
{
    public static void Main(string[] args)
    {
        /* 
        1-)Değişkenler nedir,ne işe yarar? 
         -Programlama yapılırken verilen bir değeri bilgisayarın hafızasında tutan ve istediğimiz yerde kullanmamızı sağlayan verilere değişken adı verilmektedir.
         -değişkenler verileri adreslememize yarar.

        3-)Değişken tanımlama ve değer atamaları?
         - int    = Tam sayıları depolayan veri tipidir.(15,-30 gibi)
           double = Ondalıklı sayıları depolayan veri tipidir.(19.99,25.43 gibi)
           char   = 16 bit uzunluğundaki karakterlerin karşılıklarını depolayan veri tipidir.('a', 'B' gibi)
           string = metinsel değerleri depolayan veri tipidir.("Hello World" gibi)
           bool   = değerleri iki durumda depolar.(true or false)

        4-)Sabitler nedir ne işe yarar?
        -Program boyunca sabit kalacak veriler için kullanılan tanımlamadır. Bir sabit tanımlamak için const anahtar kelimesini kullanırız.Değişkenler farklı değerler alabilirken sabitler program süresince tanımlandığı değeri korur.

        5-)Sabit tanımlama ve değer ataması?
        -const   <veri tipi>  <değişken adı>  =  değer;
        ÖRNEK:   const double pi = 3.14;
        */
       //1. algoritma
      /* Console.WriteLine("Sayi Giriniz: ");
         int sayi = Convert.ToInt32(Console.ReadLine());
          if (sayi > 0)
          {
              Console.WriteLine("Sayı pozitiftir.");
          }
          else if (sayi < 0)
          {
              Console.WriteLine("Sayı negatiftir.");
          }
          else if (sayi == 0)
          {
              Console.WriteLine("Sayı 0 a eşittir.");
          }
       //2.algoritma
         int i = 0;
         while (i < 10)
         {
             Console.WriteLine("Enis");
             i++;
         }
         Console.WriteLine("adınızı giriniz");
         string ad = Console.ReadLine();
         Console.WriteLine("sayı giriniz");
         int sayi = Convert.ToInt32(Console.ReadLine());
         int i = 0;
         while ( i < sayi)
         {
             Console.WriteLine(ad);
             i++;
         }
       //3.algoritma
         int i = 0;
         while(i <= 10)
         {
             Console.WriteLine(i);
             i = i + 2;
         }
         int i = 1;
         int toplam = 0;
         while (i <= 10)
         {
             toplam = toplam + i;
             i++;
         }
         Console.WriteLine("Toplam = {0}", toplam);
       //4.algoritma
         int i = 0;
         int toplam = 0;
         while( i <= 20)
         {
             toplam = toplam + i;
             i = i + 2;
         }
         Console.WriteLine("Toplam = {0}",toplam);
       //5.algoritma
         int sayac = 0;
         int toplam = 0;
         Console.WriteLine("sayi gir");
         while (sayac < 10)
           {
               if (sayac < 10)
               {
                   int sayi = Convert.ToInt32(Console.ReadLine());
                   sayac = sayac + 1;
                   toplam = toplam + sayi;
                   sayac++;
               }
           }
          Console.WriteLine("Toplam = {0}", toplam);
        //6.algoritma
          Console.WriteLine("1.sayi:");
          int bas = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("2.sayi:");
          int son = Convert.ToInt32(Console.ReadLine());
          int sayac = bas;
          Console.WriteLine(sayac);
          while(sayac < son)
          {
              sayac = sayac + 1;
              Console.WriteLine(sayac);
          }
          sayac++;
        //7.algoritma,
          Console.WriteLine("1.sayi:");
          int i =Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("2.sayi:");
          int x = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine(i + x);
          Console.WriteLine(i * x);
          Console.WriteLine(i / x);
          Console.WriteLine(i - x);
        //8.algoritma
          Console.WriteLine("sayi gir");
          int sayi1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("sayi gir");
          int sayi2 = Convert.ToInt32(Console.ReadLine());
          int sonuc = (sayi1 + sayi2) /2;
          Console.WriteLine("Ortalama = {0}",sonuc);
        //9.algoritma
          Console.WriteLine("uzunluğu gir ");
          int uzunluk = Convert.ToInt32(Console.ReadLine());
          int cevre = uzunluk * 4;
          Console.WriteLine("Karenin çevresi ={0}", cevre);
          int alan = uzunluk * uzunluk;
          Console.WriteLine("Karenin alanı = {0}", alan);
        //10.algoritma
          Console.WriteLine("sayi gir");
          int sayi1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("sayi gir");
          int sayi2 = Convert.ToInt32(Console.ReadLine());
          if (sayi1 > sayi2)
          {
             Console.WriteLine(sayi1 - sayi2);
          }
          else if (sayi2 > sayi1)
          {
             int sonuc = (sayi1- sayi2)*-1;
             Console.Write(sonuc);
          }
          else
          {
             return;
          }*/




    }
}


