using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
               switch (month)
            {
                case "Yanvar":
                case "May":
                case "Mart":
                case "Iyul":
                case "Avqust":
                case "Oktyabr":
                case "Dekabr":
                    Console.WriteLine("Bu ayda 31 gun var");
                        break;

                case "Aprel":
                case "Iyun":
                case "Sentyabr":
                case "Noyabr":
                    Console.WriteLine("Bu ayda 30 gun var");
                        break;
                case "Fevral":
                    Console.WriteLine("Bu ay 4 ilden bir 28-29 gun olur");
                        break;
                default:
                    Console.WriteLine("seni alladiblar bele ay yoxdur");
                    break;


                        

            }
                }
    }
}
