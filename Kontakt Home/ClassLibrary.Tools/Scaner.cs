using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tools
{
    public class Scaner
    {
        public static string ReadString(string caption)
        {
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            return aStr;
        }

        public static double ReadDouble(string msg)
        {
        l1:
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            double a;

            try
            {
                a = Convert.ToDouble(aStr);
            }
            catch
            {
                Scaner.PrintError("Yanlish daxil etme, yeniden daxil edin");
                goto l1;
            }

            return a;
        }

        public static int ReadInteger32(string msg)
        {
        l1:
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            int a;

            try
            {
                a = Convert.ToInt32(aStr);
            }
            catch
            {
                Scaner.PrintError("Yanlish daxiletme, yeniden daxil edin");
                goto l1;
            }

            return a;
        }

        public static void Print(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
