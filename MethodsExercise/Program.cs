using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;

namespace MethodsExercise
{
    public class Program
    {
        /// <summary>
        /// "MadLibs" Generator
        /// formats and ouputs a pre defined story with words input from the user
        /// </summary>
        /// <returns></returns>
        public static string getName()
        {
            Console.WriteLine("Enter you name:");
            string name = Console.ReadLine();
            return name;
        }

        public static void greetUser(string name)
        {
            Console.WriteLine($"\nHello, {name}\n");
        }

        public static string getColor()
        {
            Console.WriteLine("Enter a color:");
            string color = Console.ReadLine();
            return color;
        }

        public static string getNoun()
        {
            Console.WriteLine("Enter a noun:");
            string noun = Console.ReadLine();
            return noun;
        }

        public static string getAdverb()
        {
            Console.WriteLine("Enter an adverb:");
            string adverb = Console.ReadLine();
            return adverb;
        }

        public static string getFood()
        {
            Console.WriteLine("Enter a food:");
            string food = Console.ReadLine();
            return food;
        }

        public static string getAnimal()
        {
            Console.WriteLine("Enter an animal:");
            string animal = Console.ReadLine();
            return animal;
        }


        static void Main(string[] args)

        {
            
            Console.WriteLine("\t  Fill-In-The Blank Story with C#\n");
            string name = getName();
            greetUser(name);
            Console.WriteLine("Please enter the requested words:\n");
            string color = getColor();
            string noun = getNoun();
            string adverb = getAdverb();
            string food = getFood();
            string animal = getAnimal();
            string noun2 = getNoun();
            string food2 = getFood();


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
            Console.WriteLine($"They had conquered another coding challenge and were ready to enjoy the rest of their day with their pet {animal}.");
        }
    }
}
