
namespace SelectionStatementsExercise2
{
    public class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject mate?");

            string userInput = (Console.ReadLine().ToLower());

            switch (userInput)
            {
                case "math":
                    Console.WriteLine("Math is a great subject to study!");
                    break;

                case "english":
                    Console.WriteLine("English?..Hey I love to read!");
                    break;

                case "history":
                    Console.WriteLine("Awesome, what is the current estimate of the first human being ever?");
                    break;

                case "computer science":
                    Console.WriteLine("Wow! That's a great field, so many options to choose from there.");
                    break;

                case "psychology":
                    Console.WriteLine("Are you trying to analyze me right now?");
                    break;
                default:
                    Console.WriteLine("Hmmm.. I've never heard of that one!");
                    break;
            }
        }
    }
}

    

    
        //        public static string GetDrinkByProfession(string p)

        //        {
        //            Console.WriteLine("Hi there, I bet you'd like to know the preferred beverage associated with your profession. What do you do?");

        //            string result = char.ToUpper(p[0]) + p.Substring(1).ToLower();

        //            switch (result)
        //            {
        //                case "Jabroni":
        //                    Console.WriteLine("Patron Tequila");
        //                    break;
        //                case "School Counselor":
        //                    Console.WriteLine("Anything with Alcohol");
        //                    break;
        //                case "Programmer":
        //                    Console.WriteLine("Hipster Craft Beer");
        //                    break;
        //                case "Bike Gang Member":
        //                    Console.WriteLine("Moonshine");
        //                    break;
        //                case "Politician":
        //                    Console.WriteLine("Your tax dollars");
        //                    break;
        //                case "Rapper":
        //                    Console.WriteLine("Cristal");
        //                    break;
        //                default:
        //                    Console.WriteLine("Beer");
        //                    break;
        //            }

        //        }

        //        public static void Main(string[] args)
        //        {
        //            string profession = "Programmer";
        //            string drink = GetDrinkByProfession(profession);
        //            Console.WriteLine($"Nice. This is your preferred drink as a{profession}: {drink}");
        //        }

        //    }
        //}





