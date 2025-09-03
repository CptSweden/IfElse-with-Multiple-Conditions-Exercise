namespace IfElse_with_Multiple_Conditions_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your age?");

            int age = int.Parse(Console.ReadLine());

            if (age >= 18 && age <= 80)
            {
                Console.WriteLine("You are allowed to drive");
            }
            else
            {
                Console.WriteLine("You are NOT allowed to drive");
            }
            */

            /*
            Console.WriteLine("Enter any day of the week");

            string dayOfWeek = Console.ReadLine();
            
            if (dayOfWeek.ToLower() == "saturday" || dayOfWeek.ToLower() == "sunday")
            {
                Console.WriteLine("It's the weekend");
            }
            else
            {
                Console.WriteLine("It's a weekday.");
            }
            */

            /*
            Console.WriteLine("Do you want cheese on your pizza? (yes/no)");

            string cheese = Console.ReadLine();

            Console.WriteLine("Do you want pepperoni on your pizza? (yes/no)");

            string pepperoni = Console.ReadLine();

            if (cheese.ToLower() == "yes" && pepperoni.ToLower() == "yes")
            {
                Console.WriteLine("Cheese and pepperoni pizza coming up!");
            }
            else if (cheese.ToLower() == "yes" || pepperoni.ToLower() == "yes")
            {
                Console.WriteLine("One topping pizza");
            }
            else
            {
                Console.WriteLine("Plain pizza");
            }
            */

            /*
            Console.WriteLine("Are you a student? (yes/no)");

            string isStudent = Console.ReadLine();

            Console.WriteLine("Do you have a student card? (yes/no)");

            string studentCard = Console.ReadLine();

            if (isStudent.ToLower() == "yes" && studentCard.ToLower() == "yes")
            {
                Console.WriteLine("Access granted!");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
            */


            Console.WriteLine("Is it raining? (yes/no)");

            string rain = Console.ReadLine();

            if (rain != "yes")
            {
                Console.WriteLine("You don't need an umbrella");
            }
            else
            {
                Console.WriteLine("Take an umbrella");
            }

        }
    }
}
