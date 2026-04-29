using System;
bool sedangBerjalan = true;

while (sedangBerjalan)
{

    Console.WriteLine(" ");
    Console.WriteLine("--- PROGRAM MANDIRI --");
    Console.WriteLine(" ");

    Console.Write("Siapa namamu? Masukkan disini: ");
    string? namaKamu = Console.ReadLine();

    Console.Write("Berapa umurmu? Masukkan disini: ");
    int umurKamu = Convert.ToInt32(Console.ReadLine());

    Console.Write("Berapa tinggi badanmu? (Contoh: 170,5) Masukkan disini: ");
    float tbKamu = Convert.ToSingle(Console.ReadLine());

    Console.Write("Apakah kamu bersetatus miskin? (y/n): ");
    string status = Console.ReadLine()?.ToLower() ?? "";

    Console.WriteLine(" ");
    Console.WriteLine("----------------------");
    Console.WriteLine(" ");

    Console.WriteLine("Nama     : " + namaKamu);
    Console.WriteLine("Umur     : " + umurKamu);
    Console.WriteLine("TB       : " + tbKamu);

    if (status == "y")
    {
        Console.WriteLine("Status   : Miskin");
    }
    else if (status == "n")
    {
        Console.WriteLine("Status   : Mampu");
    }
    else
    {
        Console.WriteLine("Status   : Unknown");
    }

    Console.WriteLine("");
    Console.WriteLine("----------------------");
    Console.WriteLine(" ");
    Console.Write("Mau input lagi? (y/n): ");
    string? inputLagi = Console.ReadLine()?.ToLower();

    if (inputLagi == "n")
    {
        sedangBerjalan = false;
        Console.WriteLine(" ");
        Console.WriteLine("--- TERIMA KASIH --");
    }
}
