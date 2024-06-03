namespace MethodsExercise
{
    public class Program
    {//project 1 Mad Libs Story
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is your least favorite color?");
            string color = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is an ugly animal?");
            string animal = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine(StoryGenerator(name, color, animal, band));

            
            // end --------------------------------------------

            //Equations
            Add(23, 29);
            Subtract(34, 29);
            Divide(6, 2);
            Multiply(6, 2);
            Console.WriteLine(Add);
        
        //param
        Curry(5, 6, 3); //This will make a curry with 5 spices, 6 solid ingredients, 3 liquids
        Curry(10, 3, 2); //This will make a curry with 10 spices, 3 solid ingredients, and 2 liquids

    }
        public static string StoryGenerator(string name, string color, string animal, string band)
        {
            string story = $"Once upon a time..." +
                $"\n There was a ninja named {name}. {name} did not like wearing black." +
                $"So, they picked out a new {color} ninja outfit. " +
                $"\n{name} was excited to see {band} in concert even though the lead guitarist now played banjo." +
                $"\n{name} walked to the ticket counter. The operator was a {animal} with a support miniature horse.";

            return story;
        }


        public static void Add(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.WriteLine(answer);
        }

        public static void Subtract(int num1, int num2)
        {
            int answer = num1 - num2;
            Console.WriteLine(answer);
        }
        public static void Divide(int num1, int num2)
        {
            int answer = num1 / num2;
            Console.WriteLine(answer);

        }
        public static void Multiply(int num1, int num2)
        {
            int answer = num1 * num2;
            Console.WriteLine(answer);
        }
        public static void Curry(params int[] ingredients)
        {
        Console.WriteLine("Making a curry with the following ingredients:");
        foreach (int ingredient in ingredients)
        {
            Console.WriteLine(ingredient);
        }
        }
    }
}
