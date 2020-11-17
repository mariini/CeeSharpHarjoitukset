using System;


namespace ArvaaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints game info from function
            GetAppInfo();

            // Greets user from function
            GreetUser();

            // Loops until user ends the game
            while (true)
            {
                // Creates new random object
                Random random = new Random();

                // Inits random number to be correct one
                int oikeaNumero = random.Next(1, 10);

                // Inits number user is guessing 
                int arvaa = 0;

                // Asks user to guess a number
                Console.WriteLine("Arvaa jokin numero (1-10)?");

                // While guess is NOT correct
                while (arvaa != oikeaNumero)
                {
                    // Stores and passes given number
                    string annettuNumero = Console.ReadLine();

                    // Makes sure that user input is a number
                    if (!int.TryParse(annettuNumero, out arvaa))
                    {
                        // Prints error message
                        PrintColorMessage(ConsoleColor.Red, "Ehei, et antanut lukua. Anna luku niin olet pelissä mukana..");

                        continue;
                    }

                    // Changes string to int
                    arvaa = Int32.Parse(annettuNumero);

                    if (arvaa != oikeaNumero)
                    {
                        // Prints error message
                        PrintColorMessage(ConsoleColor.Red, "Ehei, arvaamasi luku ei ole se oikea..");
                    }
                }

                // Prints success message when guess is CORRECT
                PrintColorMessage(ConsoleColor.Yellow, "JEEE! Arvaamasi numero oli oikein!");
               

                // Asks to play again
                Console.WriteLine("Jatketaanko pelaamista, joo vai ei? [J vai E]");

                // Changes given letter to uppercase
                string vastaus = Console.ReadLine().ToUpper();

                // Continues or ends the game by given answer
                if(vastaus == "J")
                {
                    continue;
                }
                else if (vastaus == "E")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
        // Function for game info
        static void GetAppInfo()
        {
            // Game info variables
            string appName = "Arvaa Numero";
            string appVersion = "1.0.0";
            string appAuthor = "R. Marin";

            
            //Prints game info with green color
            Console.ForegroundColor = ConsoleColor.Green;

            // Prints game info variables
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Changes color back to default
            Console.ResetColor();
           
        }
        // Function to greet user
        static void GreetUser()
        {
            // Asks user name
            Console.WriteLine("Kerro nimesi?");

            // Stores and passes user input
            string pelaaja = Console.ReadLine();

            // Prints greeting for the player
            Console.WriteLine("Hei {0}, pelataanpa kierros numeron arvausta...!", pelaaja);
        }
        // Function for messages
        static void PrintColorMessage(ConsoleColor color, string viesti)
        {
            // Changes the color of the message
            Console.ForegroundColor = color;

            // Prints message to user
            Console.WriteLine(viesti);

            // Changes color back to default
            Console.ResetColor();
        }
     }
}
