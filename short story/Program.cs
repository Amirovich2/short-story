using System;

namespace short_story
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string name= Console.ReadLine();

            Console.WriteLine("what is your faviorite sport?");
            string sport = Console.ReadLine();

            Console.WriteLine("where are you from?");
            string nationality = Console.ReadLine();

            Console.WriteLine("what is your occupation?");
            string occupation = Console.ReadLine();

            Console.WriteLine("faviorite hobby?");
            string hobby = Console.ReadLine();

            Console.WriteLine($"{name} is an {occupation} from {nationality}. {name}'s faviorite sport is {sport} and loves to do {hobby}");
    }
        }
        
}
