using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Basit Hesap Makinesi (Toplama / Çıkarma)");

        Console.Write("1. Sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. Sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İşlem seçin (+ veya -): ");
        string islem = Console.ReadLine();

        double sonuc;

        if (islem == "+")
        {
            sonuc = sayi1 + sayi2;
            Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
        }
        else if (islem == "-")
        {
            sonuc = sayi1 - sayi2;
            Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
        }
        else
        {
            Console.WriteLine("Geçersiz işlem seçildi. Sadece + ve - destekleniyor.");
        }

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
