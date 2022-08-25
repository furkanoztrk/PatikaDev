using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hata();
        //    //atama  Ve işlemli atama
        //    int x=3;
        //    int y=3;
        //    y = y+2;
        //    Console.WriteLine(y);
        //    y +=2;
        //    Console.WriteLine(y);

        //    y/=1;
        //    Console.WriteLine(y);

        //    x*=2;
        //    Console.WriteLine(x);

        //    Console.WriteLine("**** Mantıksal Operatörler *****");


        //    //Mantıksal Operatörler
        //    // || . &&. !

        //    bool isSuccess=true;
        //    bool isCompleted=false;

        //    if(isSuccess && isCompleted)
        //    Console.WriteLine("Perfect");

        //     if(isSuccess || isCompleted)
        //    Console.WriteLine("Great");

        //     if(isSuccess && !isCompleted)
        //    Console.WriteLine("Fine!");

        //    Console.WriteLine("****İlişkisel Operatörler *****");


        //    // İlişkisel Operatörler
        //    // <,>,<=,==, !=

        //    int a = 3;
        //    int b = 4;
        //    bool sonuc =a<b;
        //    Console.WriteLine(sonuc);
        //    sonuc=a>b;
        //    Console.WriteLine(sonuc);
        //    sonuc=a>=b;

        //    Console.WriteLine(sonuc);
        //    sonuc=a<=b;
        //    Console.WriteLine(sonuc);
        //    sonuc=a==b;
        //    Console.WriteLine(sonuc);
        //    sonuc=a!=b;
        //    Console.WriteLine(sonuc);

        //    Console.WriteLine("****Aritmetik Operatörler *****");

        //    //Aritmetik (+, -, *, /, %, ++, --)

        //    int sayi1 = 10;
        //    int sayi2 = 5;
        //    int sonuc1= sayi1/sayi2;
        //    Console.WriteLine(sonuc1);
        //    sonuc1=sayi1*sayi2;
        //    Console.WriteLine(sonuc1); 
        //    sonuc1=sayi1+sayi2;
        //    Console.WriteLine(sonuc1);
        //    sonuc1=sayi1-sayi2;
        //    Console.WriteLine(sonuc1);

        //    // % : mod alır
        //    int sonuc2= 20%3;
        //    Console.WriteLine(sonuc2);


         // Implicit Conversion (Bilinçsiz Dönüşüm)
        //  byte a= 5;
        //  sbyte b =30;
        //  short c =10;

        //  int d =a+b+c;
        //  Console.WriteLine("d:"+d);

        //  long h =d;
        //  Console.WriteLine("h:"+h);

        //  float i =h;
        //  Console.WriteLine("i:"+i);

        //  string e = "furkan";
        //  char f = 'k';
        //  object g =e+f+d;
        //  Console.WriteLine("g:"+g);
         
        //  //Explicit Conversion (Bilinçli Dönüşüm)
        //  Console.WriteLine("*****Explicit Conversion*****");
        //  int x = 4;
        //  byte y =(byte)x;
        //  Console.WriteLine("y:"+y);

        //  int z = 100;
        //  byte t =(byte)z;
        //  Console.WriteLine("t:"+t);

        //  float w =10.3f;
        //  byte v =(byte)w;
        //  Console.WriteLine("v:"+v);

        //  //***ToString Methodu****
        //  Console.WriteLine("*****ToString Methodu*****");
        //  int xx =6;
        //  string yy =xx.ToString();
        //  Console.WriteLine("yy"+yy);
         
        //  string zz = 15.5f.ToString();
        //  Console.WriteLine("zz"+zz);
         
        //  //System.Convert
        //  Console.WriteLine("*****System.Convert*****");
        //  string s1="10",s2="20";
        //  int say1,say2;
        //  int toplam;

        //  say1 =Convert.ToInt32(s1);
        //  say2 =Convert.ToInt32(s2);
        //  toplam =say1+say2;
        //  Console.WriteLine("TOPLAM"+toplam);
         
        //  //Parse 
        //  Console.WriteLine("*****Parse*****");
        //  ParseMethod();
        }
        // public static void ParseMethod()
        // {
        //     string metin1= "10";
        //     string metin2= "10.25";
        //     int rakam ;
        //     double double1;

        //     rakam=Int32.Parse(metin1);
        //     double1= Double.Parse(metin2);
        //     Console.WriteLine("rakam : "+rakam);
        //     Console.WriteLine("double : "+double1);
        // }
        public static void hata()
        {
            try
            { Console.WriteLine("Bir Sayı Giriniz :");
              int sayi1= Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Girmiş Olduğunuz Sayı :"+sayi1);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata"+ex.Message.ToString()); 
            }
            finally
            {
                Console.Write("İşlem Tamamlandı.");
            }

            // try
            // {                           //Parse Methodu String ifadeleri int dönüştürmek için kullanılır
            // //   int a = int.Parse(null); 
            //     //  int a = int.Parse("test");
            //      int a = int.Parse("-20000000000");


            // }
            // catch (ArgumentNullException ex)
            // {
            //     Console.WriteLine("Boş Değer girdiniz : ");
            //     Console.WriteLine(ex);
            // }
            // catch (FormatException ex)
            // {
            //     Console.WriteLine("Veri tipi uygun değil  : ");
            //     Console.WriteLine(ex);
            // }
            //   catch (OverflowException ex)
            // {
            //     Console.WriteLine("Çok Küçük yada çok büyük bir değer girdiniz  : ");
            //     Console.WriteLine(ex);
            // }
            // finally{
            //     Console.WriteLine("İşlem başarıyla tamamlandı.");
            // }







        }
    }
}