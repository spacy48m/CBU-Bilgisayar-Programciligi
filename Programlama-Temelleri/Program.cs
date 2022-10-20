using System;

namespace ders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenlerin varsayılan değerleri
            //Console.WriteLine(default(decimal));
            //nullable
            //byte? sayi = null;
            /*var a = 5;
             Console.WriteLine(a.GetType());
            string cevap = a.GetType() == typeof(int) ?
            "değer int" :
            "değer bilinmiyor";
            Console.WriteLine(cevap);
            Console.WriteLine("ad soyad");
            string adsoyad =Console.ReadLine();
            Console.WriteLine($"ad soyad = {adsoyad}");*/

            //1
            /*onsole.WriteLine("ad");
             string ad= Console.ReadLine();
             Console.WriteLine("soyad");
             string soyad =Console.ReadLine();
             Console.WriteLine("memleket");
             string memleket = Console.ReadLine();
             Console.WriteLine("yas");
             int yas = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("askerlik");
             string askerlik =Console.ReadLine();
             Console.WriteLine("dil");
             string dil = Console.ReadLine();
             Console.WriteLine($"adın = {ad}, soyad = {soyad}, memleket = {memleket}, yaş = {yas}, askerlik = {askerlik}, dil = {dil}");
            
            Console.WriteLine("1.sayıyı gir: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayi gir : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1  <= 255)
            {
                num1 = (byte)num1;
            }
            int sonuc = num1 + num2;
            Console.WriteLine("sonuc= {0}",sonuc);*/
            Console.WriteLine("1.sayıyı gir: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("2.sayi gir : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("3.sayi gir : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            double sum = (double)(num1 + num2 + num3)/3;
            Console.WriteLine("ort = {0}",sum);
        }
    }
}
