internal class Program
{
    private static void Main(string[] args)
    {

        // Ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır.
        // Console.WriteLine("Bir Sayı Giriniz");
        // int sayac = int.Parse(Console.ReadLine());
        // for (int i=0; i <= sayac; i++)
        // {
        //     if(i % 2 == 1)
        //         Console.WriteLine(i);
        // }


        //1 ile 1000 arasındaki tek sayıları ayrı toplayacak, çift sayıları ayrı toplacak bir for döngüsü

        // int tekToplam = 0;
        // int ciftToplam = 0;

        // for (int i = 1; i <= 1000; i++)
        // {
        //     if(i%2 ==1)
        //         tekToplam += i; // tekToplam = tekToplam + i;
        //     else
        //         ciftToplam += i; // ciftToplam = ciftToplam + i;
        // }

        // Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);
        // Console.WriteLine("Çift Sayıların Toplamı: " + ciftToplam);

        

        //break, continue

        // for (int i = 0; i < 10; i++)
        // {
        //     if(i == 4)
        //         break;
        //     Console.WriteLine(i);
        // }

        for (int i = 0; i < 10; i++)
        {
            if(i ==5)
                continue;
            Console.WriteLine(i);
        }

    }
}