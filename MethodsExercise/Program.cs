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
            string userName = getName();
            string color = getColor();
            string noun = getNoun();
            string adverb = getAdverb();
            string food = getFood();
            string animal = getAnimal();

            Console.WriteLine(userName);
            Console.WriteLine(color);
            Console.WriteLine(noun);
            Console.WriteLine(adverb);  
            Console.WriteLine(food);
            Console.WriteLine(animal);
        }
    }
}
