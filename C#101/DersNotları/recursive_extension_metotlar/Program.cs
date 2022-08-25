﻿// See https://aka.ms/new-console-template for more information

//Rekürsif- Öz yinelemeli genellikle for döngüleri ile yapılır 
//üst alma faktoriyel almada kullanılabilir 
//3^4

        int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
                Console.WriteLine(result);
                Islemler instance =new();
                Console.WriteLine(instance.Expo(3,4));

        //Extension Metotlar
        string ifade = "Furkan Ozturk";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if (sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLoverCase());

        int[] dizi ={8,6,3,7,2,5,4};
        dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi = 5;
        Console.WriteLine(sayi.IsEvenNumber());

        Console.WriteLine(ifade.GetFirstCharacter()); 





    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return Expo(sayi,üs-1)*sayi;
        }
        //Expo (3,4)
        //Expo (3,3)*3;
        //Expo (3,2)*3*3;
        //Expo (3-1)*3 *3 *3;
        // 3*3*3*3 = 3^4;
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLoverCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param )
        {
            foreach (int item in param)
            {
                 Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }

    }