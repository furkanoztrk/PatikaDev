using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

              // Dizi Tanımlama
              string[] renkler = new string[5];

              string[] hayvanlar = {"Kedi","köpek","kuş","maymun"};

              int[] dizi ;
              dizi = new int[5];
              //Dizilere Değer atama Ve erişim
              renkler[0] = "Mavi";
              dizi[3]= 10;

              Console.WriteLine(hayvanlar[1]);
              Console.WriteLine(dizi[3]);
              Console.WriteLine(renkler[0]);

              //Döngüler ile dizi kullanımı
              // Klavyeden girilen n tane sayının ortalamasını hesaplayan program
              Console.WriteLine("Lütfen Dizinin eleman sayısını giriniz : ");
              int diziUzunlugu = int.Parse(Console.ReadLine());
              int[] sayiDizisi = new int[diziUzunlugu];

              for (int i = 0; i < diziUzunlugu; i++)
              {
                Console.Write("Lütfen {0}.Sayıyı giriniz :", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
              }

              int toplam = 0;

              foreach (var sayi in sayiDizisi)
              {
                toplam +=sayi;
              }
              Console.WriteLine("Ortalma :"+ toplam/diziUzunlugu);

              decimal positives = 0;
              decimal negatives = 0;
              decimal zeros = 0;
              decimal length = arr.Length;
              for (int i = 0; i < length; i++)
              {
                if (arr[i] < 0) negatives++;
                else if (arr[i] > 0) positives++;
                else zeros++;
              }
              Console.WriteLine($"{positives / length:F6}");
              Console.WriteLine($"{negatives / length:F6}");
              Console.WriteLine($"{zeros / length:F6}");


            






        //     //While 
        //     // 1 den başlayarak conole dan girilen sayıya kadar (sayı dahil )ortalama hesaplama
        //     Console.Write("Lütfen Bir Sayı Girin :");
        //     int sayi = int.Parse(Console.ReadLine());
        //     int sayac = 1;
        //     int Toplam = 0;
        //     while (sayac<=sayi)
        //     {
        //         Toplam+= sayac;
        //         sayac ++;

        //     }
        //     Console.WriteLine(Toplam/sayi);
            
        //     // a dan 'z 'ye kadar tüm harfleri console a yazdır
        //     Console.Write("A dan Z YE :");
        //     char character = 'a';
        //     while (character < 'z')
        //     {
        //         Console.Write(character);
        //         character++;
        //     }
            
        //     Console.Write("***** Foreach ******");
        //     string[] arabalar = {"BMV","Ford","Toyata","Nissan"};
        //     foreach (var araba in arabalar)
        //     {
        //         Console.WriteLine(araba);
        //     }



        //  //   Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
        //     Console.Write("Lütfen bİR SAYI GİRİNİZ");
        //     int sayac=int.Parse(Console.ReadLine());
        //     for (int i = 1; i < sayac; i++)
        //     {
        //         if(i%2 ==1)
        //         Console.WriteLine(i);
        //         //komutlar
        //     }
        //    // 1 İLE 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamarını ekrana yazdır
        //     int tektoplam = 0;
        //     int cifttoplam = 0;
        //     for (int i = 1; i <= 1000; i++)
        //     {
        //         if(i%2 == 1)
        //              tektoplam += i; //tektoplam = tektoplam +i;
        //         else
        //              cifttoplam += i; //tektoplam = tektoplam +i;
        //     }
        //     Console.WriteLine("Tek Toplam:" + tektoplam);
        //     Console.WriteLine("Çift Toplam:" + cifttoplam);

        //     //break ,continue
        //     for (int i = 1; i < 10; i++)
        //     {
        //         if(i==4)
        //             break;
        //         Console.WriteLine(i);
        //     }
        //       for (int i = 1; i < 10; i++)
        //     {
        //         if(i==4)
        //             continue ;
        //         Console.WriteLine(i);
        //     }
 
            // int time =DateTime.Now.Hour;

            // if(time>=6 && time<11)
            //  Console.WriteLine("Günaydın ");
            // else if(time<= 18)
            //  Console.WriteLine("İyi Günler");
            // else
            //  Console.WriteLine("İyi Geceler");

            // string sonuc = time<=18 ? "İyi Günler" :"İyi Geceler";
            // sonuc =time>=6 && time<11 ? "Günaydın" :time<=18 ?"İyi Günler": "İyi geceler!"
            //  Console.WriteLine(sonuc);
            // int month = DateTime.Now.Month;
            //Expression
            // switch (month) 
            // {
            //     case 1:
            //         Console.WriteLine("Ocak Ayındasınız !");
            //         break;
            //     case 7:
            //         Console.WriteLine("Temmuz Ayındasınız !");
            //         break;
            //     case 4:
            //         Console.WriteLine("Nisan Ayındasınız !");
            //         break;
            //     case 3:
            //         Console.WriteLine("Mart Ayındasınız !");
            //         break;
                
            //     default:
            //      Console.WriteLine("Yanlış Veri Girdiniz!");
            //     break;
            // }
            // switch (month)
            // {
            //     case 12:
            //     case 1:
            //     case 2:
            //         Console.WriteLine("Kış Ayındasınız");
            //         break;
            //     case 3:
            //     case 4:
            //     case 5:
            //         Console.WriteLine("İlkbahar Ayındasınız");
            //         break;
            //     case 6:
            //     case 7:
            //     case 8:
            //         Console.WriteLine("Yaz Ayındasınız");
            //         break;
            //     case 9:
            //     case 10:
            //     case 11:
            //         Console.WriteLine("Sonhabar Ayındasınız");
            //         break;        
            // }     
        }
    }
}