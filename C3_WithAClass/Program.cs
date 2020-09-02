using System;

namespace C3_WithAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.Write("Welcome Dude! What´s your name? ");
            person.Name = Console.ReadLine();

            Console.Write($" {person.Name} sweet :) How old are you man? ");

            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude! Youra age must be in digits. Try again Man!");
                Console.Write("How old are you man? ");

                try
                {
                    person.Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dude you are dumb");
                }
            }
            finally
            {
                Console.WriteLine($"Oh cool man! We are the same age. I am also {person.Age}.");
            }

            Console.WriteLine($"Dude your name contains {person.Name.Length} characters.");
            Console.Write($"{person.Name} Where do you live? ");
            var city = Console.ReadLine();

            Console.WriteLine($"Sweet! My brother lives in {city}");
        }
    }
}
