using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace RandomHits
{
    public partial class Program 
    {
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
        public static void Main()
        {

            List<Hits> hit = new();
            string userInput = "";


            do
            {
                                
                {
                    Console.ForegroundColor = GetRandomConsoleColor();

                    AddHits(hit);
                    Console.ResetColor();

                    Console.WriteLine("To EXIT PROGRAM, Type \"exit\" or hit enter to go again.");

                    userInput = Console.ReadLine();
                }
            } while (userInput != "exit");
            Console.ResetColor();

            // hit.ForEach((Hits) => { Console.WriteLine(Hits.GetHits); });



            static void AddHits(List<Hits> damage)
            {

                Random rd = new();
                int rand_num = rd.Next(0, 36);

                Hits hit = new()
                {
                    GetHits = rand_num
                };


                damage.Add(hit);

                Console.WriteLine($"----------- Hit enter to continue -----------");
                Console.WriteLine(rand_num);
               

            }




        }
      
    }
}
