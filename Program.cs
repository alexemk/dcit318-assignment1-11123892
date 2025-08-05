
using System;

namespace DCIT318_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator.Run();
                        break;
                    case "2":
                        TicketPriceCalculator.Run();
                        break;
                    case "3":
                        TriangleTypeIdentifier.Run();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }

    class GradeCalculator
    {
        public static void Run()
        {
            Console.Write("Enter numerical grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
                Console.WriteLine("Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }
    }

    class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            int price = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Ticket Price: GHC{price}");
        }
    }

    class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.Write("Enter side 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter side 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter side 3: ");
            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
