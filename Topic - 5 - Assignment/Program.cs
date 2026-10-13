namespace Topic___5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mode, mult = "x", sub = "-", add = "+", div = "/", squareRoot = "root";
            int number, number2, venus = 1, mars = 2, jupiter = 3, saturn = 4, uranus = 5, neptune = 6;
            double weight, result;

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
*/
            //part 2
            Console.WriteLine("Choose below which mode to want to use:");
            Console.WriteLine("+   -   x   /  or  root");
            mode = Console.ReadLine();
            if (mode == add)
            {
                Console.WriteLine("Enter first number.");
                int.TryParse(Console.ReadLine(), out number);
                Console.WriteLine("Enter second number.");
                int.TryParse(Console.ReadLine(), out number2);
                Console.WriteLine("The answer is " + (number + number2));
            }
            else if (mode == sub)
            {
                Console.WriteLine("Enter first number.");
                int.TryParse(Console.ReadLine(), out number);
                Console.WriteLine("Enter second number.");
                int.TryParse(Console.ReadLine(), out number2);
                Console.WriteLine("The answer is " + (number + number2));
            }
            else if (mode == mult)
            {
                Console.WriteLine("Enter first number.");
                int.TryParse(Console.ReadLine(), out number);
                Console.WriteLine("Enter second number.");
                int.TryParse(Console.ReadLine(), out number2);
                Console.WriteLine("The answer is " + (number * number2));
            }
            else if (mode == div)
            {
                Console.WriteLine("Enter first number.");
                int.TryParse(Console.ReadLine(), out number);
                Console.WriteLine("Enter second number.");
                int.TryParse(Console.ReadLine(), out number2);
                Console.WriteLine("The answer is " + (number / number2));
            }
            else if (mode == squareRoot)
            {
                Console.WriteLine("Enter first number.");
                int.TryParse(Console.ReadLine(), out number);
                result = Math.Sqrt(number);
                Console.WriteLine("The square root is " + result);
            }
            else
            {
                Console.WriteLine("Sorry thats not an option");
            }




        }
    }
}
