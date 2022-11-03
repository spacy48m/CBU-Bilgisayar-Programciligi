namespace ders
{
    class Program
    {
        static void Ft_strlen(string str)
        {
            int i = 0;
            foreach (char c in str)
                if (str[0] == ' ')
                {
                    Environment.Exit(0);
                }
                else
                    i++;
            Console.WriteLine(i);
        }
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
            //onsole.WriteLine("ad");
            //string ad = Console.ReadLine();
            //Console.WriteLine("soyad");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("memleket");
            //string memleket = Console.ReadLine();
            //Console.WriteLine("yas");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("askerlik");
            //string askerlik = Console.ReadLine();
            //Console.WriteLine("dil");
            //string dil = Console.ReadLine();
            //Console.WriteLine($"adın = {ad}, soyad = {soyad}, memleket = {memleket}, yaş = {yas}, askerlik = {askerlik}, dil = {dil}");

            //Console.WriteLine("1.sayıyı gir: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayi gir : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 <= 255)
            //{
            //    num1 = (byte)num1;
            //}
            //int sonuc = num1 + num2;
            //Console.WriteLine("sonuc= {0}", sonuc);
            /*Console.WriteLine("1.sayi gir : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("2.sayi gir : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("3.sayi gir : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            double sum = (double)(num1 + num2 + num3)/3;
            Console.WriteLine("ort = {0}",sum);*/
            /* Console.WriteLine("not gir :");
             string not = Console.ReadLine();
             bool cevap = int.TryParse(not, out int s1);
             Console.WriteLine(cevap);*/
            /* Console.WriteLine("isim gir =");
             string str = Console.ReadLine();
             Console.WriteLine("uzunluğu =");
             Strlen(str);*/
            /*string str = "deneme";
            string str2 = "a7a";
            //belirtilmemiş
            Console.WriteLine(str.Remove(5));
            //belirtilmiş
            Console.WriteLine(str.PadLeft(10,'*'));
            Strlen(str);
            Strlen(str2);
            Console.WriteLine(string.Concat(str,' ',str2));
            str = string.Empty;
            Console.WriteLine(string.IsNullOrEmpty(str));
            string ad = "enis";
            string soyad = "ertanrikulu";
            string sonuc = ad[0].ToString().PadRight(ad.Length, '*') + " " + soyad[0].ToString().PadRight(soyad.Length, '*');
            Console.WriteLine(sonuc);
            Ft_strlen(ad + soyad);
            Console.WriteLine("ad gir");
            string name = Console.ReadLine();
            Console.WriteLine("soyad gir");
            string surname = Console.ReadLine();
            Console.WriteLine("tc gir");
            string tc = (Console.ReadLine());
            string sum = name[0].ToString().PadRight(name.Length, '*') + " " + surname[0].ToString().PadRight(surname.Length, '*') + " " + tc[2].ToString().PadRight(tc.Length, '*');
            Console.WriteLine(sum);
            string msg = "MTA nigger";
            var val = msg.Split();
            Console.WriteLine(val[1]);*/
            //  string nm = "Enis";//
            //  string nm2 = "Melis";//
            string[] names = new string[5];
            names[0] = "Enis";
            names[1] = "Denis";
            names[2] = "Wnis";
            names[3] = "Rnis";
            names[4] = "Tnis";
            int[] nums = new int[5];
            nums[0] = 5;
            nums[1] = 6;
            nums[2] = 7;
            nums[3] = 8;
            nums[4] = 9;
            Console.WriteLine(names[4]);
            Console.WriteLine(nums[4]);


        }
    }
}
