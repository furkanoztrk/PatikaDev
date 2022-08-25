using System.Collections.Generic;

Dictionary <int,string> kullanıcılar = new Dictionary<int, string>();

kullanıcılar.Add(10,"Ayşe Yaz");
kullanıcılar.Add(12,"Ahmet Yılmaz");
kullanıcılar.Add(18,"Deniz Arsa");
kullanıcılar.Add(20,"Ozcan Coşar");
// Dizinin elemanlaran erisin

Console.WriteLine("*** Elemanlara Erişin ******");
Console.WriteLine(kullanıcılar[12]);
    foreach(var item in kullanıcılar)
    {
        Console.WriteLine(item);
    }

 // Count
Console.WriteLine("****Count****");
Console.WriteLine(kullanıcılar.Count);

// Contains
Console.WriteLine("****Contains****");
Console.WriteLine(kullanıcılar.ContainsKey(12));
Console.WriteLine(kullanıcılar.ContainsValue("Furkan Öztürk"));

// Remove
Console.WriteLine("*** Remove ****");
kullanıcılar.Remove(12);
  foreach(var item in kullanıcılar)
    {
        Console.WriteLine(item);
    }

//Keys
foreach(var item in kullanıcılar.Keys)
    {
        Console.WriteLine(item);
    }
//Values
foreach(var item in kullanıcılar.Values)
    {
        Console.WriteLine(item);
    }