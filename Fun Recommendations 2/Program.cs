using System;

namespace Fun_Recommendations_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, What are you in the mood for?");
            Console.WriteLine("If you want an activity for? ");
            Console.WriteLine("Your options are!");
            Console.WriteLine("A) Action");
            Console.WriteLine("B) Chilling");
            Console.WriteLine("C) Danger");
            Console.WriteLine("D) Good Food\n");

            string activity = Console.ReadLine();

            Console.WriteLine("How many people are you bringing with you?");

            string numPeople = Console.ReadLine();

            if (activity != "A" && activity != "B" && activity != "C" && activity != "D")
            {
                Console.WriteLine("Activity not understood");
                Environment.Exit(1);
            }

            int people;
            if (!int.TryParse(numPeople, out people))
            {
                Console.WriteLine("Invalid Number Of People");
                Environment.Exit(1);
            }

            Console.Write("\nOkay if you're in the mood for ");

            if (activity == "A")
            {
                Console.Write("action");
            }
            else if (activity == "B")
            {
                Console.Write("chilling");
            }
            else if (activity == "C")
            {
                Console.Write("danger");
            }
            else if (activity == "D")
            {
                Console.Write("good food");
            }

            Console.WriteLine(" then you should go");

            if (activity == "A")
            {
                Console.Write("stock car racing");
            }
            else if (activity == "B")
            {
                Console.Write("hiking");
            }
            else if (activity == "C")
            {
                Console.Write("skydiving");
            }
            else if (activity == "D")
            {
                Console.Write("to Taco Bell");
            }

            Console.Write(" and travel in ");

            if (people == 0)
            {
                Console.WriteLine("sneakers");
            }
            else if (people > 0 && people < 5)
            {
                Console.WriteLine("a sedan");
            }
            else if (people > 4 && people < 11)
            {
                Console.WriteLine("a volkswagen bus");
            }
            else if (people > 10)
            {
                Console.WriteLine("an airplane");
            }

            Console.WriteLine("\nGoodbye User!");
        }
    }
}
