using ClassLibrary1.Helper;
using System;


namespace ConsoleApp.Smartphones.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Phones";

            int len;
        l1:
            len = Phones.ReadInteger("Nece Telefon Olsun: ");
            if (len <= 0)
            {
                goto l1;
            }
            Phones[] phones = new Phones[len];

            for (int i = 0; i < len; i++)
            {
                Phones phone = new Phones();

                Console.WriteLine($"{i + 1} Telefon Xususiyyetleri: ");

                phone.Model = Phones.ReadInteger32("Model: ");
                phone.Producer = Phones.ReadString("Istehsalatci: ");
                phone.MainCamera = Phones.ReadInteger32("Esas Kamera: ");
                phone.Ram = Phones.ReadInteger32("Ram: ");
                phone.Memory = Phones.ReadInteger32("Yaddas: ");
                phone.ProductionYear = Phones.ReadInteger32("Buraxilis Ili: ");
                phone.OperatingSystem = Phones.ReadString("Emeliyyat Sistemi: ");
                phone.BatteryCapacity = Phones.ReadInteger32("Batareya Tutumu: ");
                phone.Price = Phones.ReadDouble("Qiymet: ");

                phones[i] = phone;

                Console.WriteLine("***************************");
            }

            Console.WriteLine("-------------List of Phones--------------");

            foreach (var item in phones)
            {
                Console.WriteLine(item);
                Console.WriteLine("++++++++++++++++++++++");
            }

            Console.ReadKey();
        }
    }
}
