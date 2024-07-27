using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic;
using System.Net.Http.Headers;

namespace MethodsExercise
{
    public class Program
    {
        //Exercise 1 methods
        public static string GetName()
        {
            Console.WriteLine("Enter you name:");
            string name = Console.ReadLine();
            return name;
        }

        public static string GreetUser(string name)
        {
            Console.WriteLine($"\nHello, {name}\n");
        }

        public static string GetColor()
        {
            Console.WriteLine("Enter a color:");
            string color = Console.ReadLine();
            return color;
        }

        public static string GetNoun()
        {
            Console.WriteLine("Enter a noun:");
            string noun = Console.ReadLine();
            return noun;
        }

        public static string GetAdverb()
        {
            Console.WriteLine("Enter an adverb:");
            string adverb = Console.ReadLine();
            return adverb;
        }

        public static string GetFood()
        {
            Console.WriteLine("Enter a food:");
            string food = Console.ReadLine();
            return food;
        }

        public static string GetAnimal()
        {
            Console.WriteLine("Enter an animal:");
            string animal = Console.ReadLine();
            return animal;
        }

        //Exercise 2 methods
        public static int Add(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }

        public static int Multiply(params int[] nums) 
        {
            int product = 1;
            foreach (int num in nums)
            {
                product *= num;
            }
            return product;
        }


        static void Main(string[] args)

        {
            //Exercise 1
            Console.WriteLine("\t\t- Exercise 1 -");
            Console.WriteLine("\tFill-In-The Blank Story with C#\n");
            string name = GetName();
            GreetUser(name);
            Console.WriteLine("Please enter the requested words:\n");
            string color = GetColor();
            string noun = GetNoun();
            string adverb = GetAdverb();
            string food = GetFood();
            string animal = GetAnimal();
            string noun2 = GetNoun();
            string food2 = GetFood();
            

            Console.WriteLine("\t- A Day in the Life of a Developer -\n");
            Console.WriteLine($"{name} was a {noun2} developer with a {adverb} passion for coding.");
            Console.WriteLine($"Every morning, they would put on their lucky {color} wristband, {adverb} brew a cup of {food}, and sit down at their {noun} desk,\n ready to tackle the day\'s challenges.");

            Console.WriteLine($"Today, the task at hand was to debug a particularly {adverb} bug that was causing the {noun} application to crash."); 
            Console.WriteLine($"With a {adverb} focus, they dove into the code, line by line, determined to find the culprit.\n");

            Console.WriteLine($"After hours of {adverb} troubleshooting, a breakthrough came.");
            Console.WriteLine($"They realized the problem was a {noun} error in the {noun2} module.");
            Console.WriteLine($"With a triumphant {adverb}, they fixed the issue and ran the tests. Success!!!!\n");


            Console.WriteLine($"To celebrate, they decided to take a short break and enjoy a {food2} snack.");
            Console.WriteLine($"Refreshed and energized, they returned to their {noun}, eager to implement a new {noun2} feature.");
            Console.WriteLine($"As the workday drew to a close, {name} felt a sense of accomplishment.");
            Console.WriteLine($"They had conquered another coding challenge and were ready to enjoy the rest of their day with their pet {animal}.\n");

            //Exercise 2
            
            Console.WriteLine("\t- Exercise 2 -");
        

            Console.WriteLine($"Sum: {Add(1,1,1,1,1,1)}");
            Console.WriteLine($"Product: {Multiply(2,2,2,2)}");
        }
    }
}
