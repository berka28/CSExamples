using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int age = 0;

            Console.Write("Welcome Dude! What´s your name? ");
            name = Console.ReadLine();

            Console.Write($" {name} sweet :) How old are you man? ");
            
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                // age = Convert.ToInt32(Console.ReadLine());
                // age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude! Youra age must be in digits. Try again Man!");
                Console.Write("How old are you man? ");

                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Dude you are dumb");
                }
            }
            finally
            {
                Console.WriteLine($"Oh cool man! We are the same age. I am also {age}.");
            }

            Console.WriteLine($"Dude your name contains {name.Length} characters.");
            Console.Write($"{name} Where do you live? ");
            var city = Console.ReadLine();

            Console.WriteLine($"Sweet! My brother lives in {city}");
        }
    }
}
