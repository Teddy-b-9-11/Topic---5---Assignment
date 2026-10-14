namespace Topic___5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mode, mult = "x", sub = "-", add = "+", div = "/", squareRoot = "root", question, answer;
            int number, venus = 1, mars = 2, jupiter = 3, saturn = 4, uranus = 5, neptune = 6, score;
            double weight, result, number1, number2;

            /*
            //part 1
            Console.WriteLine("Do you want to know how much you weight on other planets?");
            Console.WriteLine("Then enter your earth weight below:");
            double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("which planet do you want to visit, these are the only ones i have information for.");
            Console.WriteLine("1. Venus   2. Mars   3. Jupiter");
            Console.WriteLine("4. Saturn   5. Uranus   6. Neptune");
            Console.WriteLine("Enter number of where you want to go below:");
            int.TryParse(Console.ReadLine(), out number);
            if (number == venus)
                Console.WriteLine("Your weight on Venus would be " + (weight * 0.78));
            else if (number == mars)
                Console.WriteLine("Your weight on Mars would be " + (weight * 0.39));
            else if (number == jupiter)
                Console.WriteLine("Your weight on Jupiter would be " + (weight * 2.65));
            else if (number == saturn)
                Console.WriteLine("Your weight on Saturn would be " + (weight * 1.17));
            else if (number == uranus)
                Console.WriteLine("Your weight on Uranus would be " + (weight * 1.05));
            else if (number == neptune)
                Console.WriteLine("Your weight on Neptune would be " + (weight * 1.23));
            else
                Console.WriteLine("Sorry, I dont have information for that planet.");

            //part 2
            Console.WriteLine("Choose below which calculator mode to want to use:");
            Console.WriteLine("+   -   x   /  or  root");
            mode = Console.ReadLine();
            if (mode == add)
            {
                Console.WriteLine("Enter first number.");
                double.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine("Enter second number.");
                double.TryParse(Console.ReadLine(), out number2);
                Console.WriteLine("The answer is " + (number1 + number2));
            }
            else if (mode == sub)
            {
                Console.WriteLine("Enter first number.");
                double.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine("Enter second number.");
                double.TryParse(Console.ReadLine(), out number2);
                Console.WriteLine("The answer is " + (number1 - number2));
            }
            else if (mode == mult)
            {
                Console.WriteLine("Enter first number.");
                double.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine("Enter second number.");
                double.TryParse(Console.ReadLine(), out number2);
                Console.WriteLine("The answer is " + (number1 * number2));
            }
            else if (mode == div)
            {
                Console.WriteLine("Enter first number.");
                double.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine("Enter second number.");
                double.TryParse(Console.ReadLine(), out number2);
                Console.WriteLine("The answer is " + (number1 / number2));
            }
            else if (mode == squareRoot)
            {
                Console.WriteLine("Enter the number.");
                double.TryParse(Console.ReadLine(), out number1);
                result = Math.Sqrt(number1);
                Console.WriteLine("The square root is " + result);
            }
            else
            {
                Console.WriteLine("Sorry, that's not an option");
            }
            */
            //part 3
            Console.WriteLine("Quiz Time");
            Console.WriteLine("Whats the capital of France?");
            Console.WriteLine("A) Rome   B) Paris   C) London   D) Ottawa");
            answer = Console.ReadLine();
            question = "B";
            score = 0;
            if (answer == question)
            {
                Console.WriteLine("Correct", score + 1);
                Console.WriteLine("Oui oui oui it is paris");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine("How many movies does star wars have");
            answer = Console.ReadLine();
            question = "12";
            if (answer == question)
            {
                Console.WriteLine("Correct", score + 1);
                Console.WriteLine("They have had 12 major theatrical Star Wars movies");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        
            Console.WriteLine("True or False");
            Console.WriteLine("Vincent van Gogh was famous while he was alive");
            answer = Console.ReadLine();
            question = "False";
            if (answer == question)
            {
                Console.WriteLine("Correct", score + 1);
                Console.WriteLine("He lived a sad life and only become famous long after this death");
            }
            else
            {
                Console.WriteLine("Incorrect");
                Console.WriteLine("Sadly it was false he never knew he work become famous :(");
            }

            Console.WriteLine("Which Marvel character  is known for having cancer");
            answer = Console.ReadLine();
            question = "Deadpool";
            if (answer == question)
            {
                Console.WriteLine("Correct", score + 1);
                Console.WriteLine("Deadpool may be unkillable but he still has major cancer");
            }
            else
            {
                Console.WriteLine("Incorrect");
                Console.WriteLine("Sorry its not " + answer);
            }

            Console.WriteLine("Time to count up your score");
            if (score == 0)
            {
                Console.WriteLine("Nice try random trivia just might not be your thing.");
                Console.WriteLine("You scored 0%");
            }
            else if (score == 4) 
            {
                Console.WriteLine("Way to go, you seem to be great at random trivia, it might be your thing.");

        }
    }
}
