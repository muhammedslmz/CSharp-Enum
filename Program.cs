using System;
namespace CSharp_Enum
{
    class Program
    {
        static void Main (string[]args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cuma);

            int sıcaklık=32;
            if(sıcaklık<(int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını beklemeslisin.");
                else if (sıcaklık>=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
                else if (sıcaklık>=(int)HavaDurumu.Normal&& sıcaklık<(int)HavaDurumu.ÇokSıcak)
                Console.WriteLine("Hadi dışarıya çıkalım.");
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çariamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk= 5, Normal=20, Sıcak=25, ÇokSıcak=30

    }
}