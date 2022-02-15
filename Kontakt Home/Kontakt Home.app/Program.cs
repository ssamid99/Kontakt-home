using System;
using ClassLibrary.Tools;

namespace Kontakt_Home.app
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Phones";

            int len;
        l1:
            len = Scaner.ReadInteger32("Nece Telefon Olsun: ");
            if (len <= 0)
            {
                goto l1;
            }
            Phones[] stores = new Phones[len];

            for (int i = 0; i < len; i++)
            {
                Phones phone = new Phones();

                Console.WriteLine($"{i + 1} Telefon Xususiyyetleri: ");

                phone.Model = Scaner.ReadString("Model: ");
                phone.Producer = Scaner.ReadString("Istehsalatci: ");
                phone.MainCamera = Scaner.ReadInteger32("Esas Kamera: ");
                phone.Ram = Scaner.ReadInteger32("Ram: ");
                phone.Memory = Scaner.ReadInteger32("Yaddas: ");
                phone.ProductionYear = Scaner.ReadInteger32("Buraxilis Ili: ");
                phone.OperatingSystem = Scaner.ReadString("Emeliyyat Sistemi: ");
                phone.BatteryCapacity = Scaner.ReadInteger32("Batareya Tutumu: ");
                phone.Price = Scaner.ReadDouble("Qiymet: ");

                stores[i] = phone;
            }

            Scaner.Print("-------------List of Phones--------------");

            foreach (var phone in stores)
            {
                Console.WriteLine(phone);
                Scaner.Print("****************************************************");
            }

            Console.ReadKey();
        }
    }
}
