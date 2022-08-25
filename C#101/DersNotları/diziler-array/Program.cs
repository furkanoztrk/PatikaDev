// See https://aka.ms/new-console-template for more information

//sort türü
Console.WriteLine("***** Sırasız Dizi******");

int[] sayıDizisi = {23,12,4,86,72,3,11,17};
foreach (var sayi in sayıDizisi)
{
Console.WriteLine(sayi);
}

Console.WriteLine("***** Sıralı Dizi******");

Array.Sort(sayıDizisi);
foreach (var sayi in sayıDizisi)
{
Console.WriteLine(sayi);
}

// Array Clear
Console.WriteLine("*****Array Clear ******");

Array.Clear(sayıDizisi,2,2);
foreach (var sayi in sayıDizisi)
{
Console.WriteLine(sayi);
}

//Array Reverse
Console.WriteLine("*****Array Reverse ******");
Array.Reverse(sayıDizisi);
foreach (var sayi in sayıDizisi)
{
Console.WriteLine(sayi);
}

// IndexOf
Console.WriteLine("*****Array IndexOf ******");
Console.WriteLine(Array.IndexOf(sayıDizisi,23));

// Resize
Console.WriteLine("*****Array Resize ******");
Array.Resize<int>(ref sayıDizisi,9);
sayıDizisi[8] =99;
foreach (var sayi in sayıDizisi)
{
Console.WriteLine(sayi);
}




