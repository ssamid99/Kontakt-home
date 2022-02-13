using System;
using System.Threading;
using ClassLibrary.Helpers;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            do
            {
            l1:
                Console.Write("Eded daxil edin: ");
                string bStr = Console.ReadLine();
                int c;
                bool qq = int.TryParse(bStr, out c);
                if (qq)
                {


                    //string wSpace = new string(' ', Console.WindowWidth);
                    //Console.CursorTop--;
                    //Console.WriteLine(wSpace);
                    //Console.CursorTop--;
                    Console.Clear();
                    switch (c)
                    {
                        case 1:
                            {
                              

                                Console.WriteLine("Yanvar");
                                break;
                            }
                        case 2:
                            {
                               
                                Console.WriteLine("Fevral");
                                break;
                            }
                        case 12:
                            {
                                
                                Console.WriteLine("Dekabr");
                                break;
                            }
                        case 3:
                            {
                                
                                Console.WriteLine("Mart");
                                break;
                            }
                        case 4:
                            {
                                
                                Console.WriteLine("Aprel");
                                break;
                            }
                        case 5:
                            {
                                
                                Console.WriteLine("May");
                                break;
                            }
                        case 6:
                            {
                                
                                Console.WriteLine("Iyun");
                                break;
                            }
                        case 7:
                            {
                                
                                Console.WriteLine("Iyul");
                                break;
                            }
                        case 8:
                            {
                                
                                Console.WriteLine("Avqust");
                                break;
                            }
                        case 9:
                            {
                                
                                Console.WriteLine("Sentyabr");
                                break;
                            }

                        case 10:
                            {
                                
                                Console.WriteLine("Oktyabr");
                                break;
                            }
                        case 11:
                            {
                                
                                Console.WriteLine("Noyabr");
                                break;
                            }
                        default:
                            {
                               
                                Console.WriteLine("eded duzgun deyil");
                                goto l1;
                            }

                    }

                }
                Console.WriteLine("Please push The Enter button for continue!!!");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string word = "DSADADS";
            char first;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            do
            {
                
                Console.Clear();
                Console.WriteLine(word);
                first = word[word.Length-1];
                word = first + word.Substring(0, word.Length-1);

                Thread.Sleep(100);

            } while (true);
            */
            string soz = "asaaeybfnxzblc";
            char a;
            char b;
            int countA = 0; 
            int countB = 0;
            for(int i = 0; i < soz.Length; i++)
            {
                if (soz[i] == 'a')
                {
                    countA++;
                }
                else if (soz[i] == 'b')
                {
                    countB++;
                }
                
            }
            double cavab = countA * 1.0 / countB;
            Console.WriteLine(cavab);


        }
    }
}
