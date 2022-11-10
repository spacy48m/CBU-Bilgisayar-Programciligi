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
           /* string[] names = new string[5];
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
            Console.WriteLine(nums[4]);*/
            /*   string[] isimler = { "Yasin", "Bora", "Eftalya", "Hatice", "Melih" };
            var cevap = Array.FindAll(isimler, eleman => eleman.Contains('a'));
            Console.WriteLine(cevap[2]);
            Array.ForEach(cevap, eleman =>
            {
                Console.WriteLine(eleman);
            });
            Ft_strlen(isimler[0] + isimler[1] + isimler[2] + isimler[3] + isimler[4]);*/
            //10.11.2022
            /*Datetime Methods*/
            /* DateTime pt = DateTime.Now;
            /*  //ToLongDateString
              Console.WriteLine($"ToLongDateString:{pt.ToLongDateString()}");
              Console.WriteLine($"ToShortDateString:{pt.ToShortDateString()}");
              Console.WriteLine($"ToLongTimeString:{pt.ToLongTimeString()}");
              Console.WriteLine($"ToShortTimeString:{pt.ToShortTimeString()}");
              Console.WriteLine($"Year:{pt.Year}");
              Console.WriteLine($"Day:{pt.Day}");
              Console.WriteLine($"DayOfWeek:{pt.DayOfWeek}");
              Console.WriteLine($"Hour:{pt.Hour}");
              Console.WriteLine($"Minute:{pt.Minute}");
              Console.WriteLine($"Second:{pt.Second}");
            DateTime nd = pt.AddDays(2).AddYears(-12).AddMonths(5).AddHours(5).AddMinutes(30).AddSeconds(40).AddMilliseconds(49);
            Console.WriteLine(nd);
            DateTime a7 = new(2001, 12, 20, 7, 0, 0);
            Console.WriteLine(a7);
            TimeSpan aa = pt - a7;
            Console.WriteLine("toplam yıl: {0}", aa.Days / 360);
            // stringle biçimleme
            //bu format gün ay yılı sayısal gösterir.
            Console.WriteLine("d formatı = {0}", pt.ToString("d"));
            //gün ay yılı uzun olarak verir.
            Console.WriteLine("D formatı = {0}", pt.ToString("D"));
            Console.WriteLine("t formatı = {0}", pt.ToString("t"));
            Console.WriteLine("T formatı = {0}", pt.ToString("T"));
            Console.WriteLine("f formatı = {0}", pt.ToString("f"));
            Console.WriteLine("F formatı = {0}", pt.ToString("F"));
            Console.WriteLine("y formatı = {0}", pt.ToString("y"));
            //uzun formatlı ToString() kullanımı
            Console.WriteLine("dd = {0}", pt.ToString("ddd"));
            Console.WriteLine("MM = {0}", pt.ToString("MMM"));
            Console.WriteLine("YY = {0}", pt.ToString("yyyy"));
            //12 lik saat
            Console.WriteLine("hh = {0}", pt.ToString("hh"));
            //24 lük saat
            Console.WriteLine("HH= {0}", pt.ToString("HH"));
            //dakika
            Console.WriteLine("mm= {0}", pt.ToString("mm"));
            //saniye
            Console.WriteLine("ss= {0}", pt.ToString("ss"));
            Console.WriteLine(pt.ToString("dd MMMM ddd yyyy HH:mm:ss"));
            //ülkelere  göre kullanım
            CultureInfo culture = new CultureInfo("es");
            Console.WriteLine(pt.ToString("dd MMMM ddd yyyy HH:mm:ss", culture));*/
        }
    }
}
