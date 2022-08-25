using System.Collections;
using System.Collections.Generic;

        ArrayList liste = new ArrayList();


        // Console.WriteLine(liste[1]);

        // foreach (var item in liste)
        // {
        //     Console.WriteLine(item);
        // }

        // AddRange ArrayListe collection eklemeye yarar yad daha büyük veriler 

        string[] renkler = {"kırmızı","mavi","yeşil"};
        List<int> sayilar =new List<int>{2,4,67,8,9,6,3,52};

        // liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach (var item in liste)
        {
        Console.WriteLine(item);
        }

        // Sort küçükten büyüğe sıralama 
        Console.WriteLine("****Sort****");
        liste.Sort();

        foreach (var item in liste)
        {
        Console.WriteLine(item);
        }
        // Binary Search
        Console.WriteLine("****Binary Search****");
        Console.WriteLine(liste.BinarySearch(4));


        // Reverse tersen sıralama
        Console.WriteLine("****Reverse****");

        liste.Reverse();
        foreach (var item in liste)
        {
        Console.WriteLine(item);
        }

        // Clear ArrayList içindeki bütün verileri siler 

        Console.WriteLine("****Clear****");
        liste.Clear();

        liste.Add("Furkan");
        liste.Add(6);
        liste.Add(true);
        liste.Add('F');

        foreach (var item in liste)
        {
        Console.WriteLine(item);
        }