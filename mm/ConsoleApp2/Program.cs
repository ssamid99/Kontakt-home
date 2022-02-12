using System;
using ClassLibrary.Helpers;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            string bStr = Console.ReadLine();
            int a;
            bool qq = int.TryParse(bStr, out a);
            if (qq)
            {
                int c = 0;
                //while (a > 10)
                //{
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    c = qaliq;
                //}
               
                switch (c)
                {
                    case 1:
                        {

                        }
                    case 2:
                    case 12:
                        {
                            Console.WriteLine("Qish");
                            break;
                        }
                    case 3:
                    case 4:
                    case 5:
                        {
                            Console.WriteLine("Yaz");
                            break;
                        }
                    case 6:
                    case 7:
                    case 8:
                        {
                            Console.WriteLine("Yay");
                            break;
                        }
                    case 9:
                    case 10:
                    case 11:
                        {
                            Console.WriteLine("Payiz");
                            break;
                        }

                }

                Console.WriteLine(c);

            }
        }
    }
}
