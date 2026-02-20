using System.Runtime.ExceptionServices;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first name");
            string name = Console.ReadLine();
            Console.WriteLine("enter second name");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter date of birth");
            string age1 = Console.ReadLine();
            Console.WriteLine("enter name of school");
            string name2 = Console.ReadLine();
            Console.WriteLine("enter state of origin");
            string name3 = Console.ReadLine();
            Console.WriteLine("enter the name of best food");
            string name4 = Console.ReadLine();
            Console.WriteLine("enter the name of best friend");
            string name5 = Console.ReadLine();
            Console.WriteLine("enter the name of besrt movie");
            string name6 = Console.ReadLine();

            Console.WriteLine("/nUser Detail");
            Console.WriteLine($"name my name is {name} {name1},I am {age} years old. I was given birth in {age1},the name of my school is {name2}" +
                $"My local government area is {name3},The name of my best food is {name4},The name of my best friend is {name5}, And the name of my best movie is {name6}");

        }
    }
}
