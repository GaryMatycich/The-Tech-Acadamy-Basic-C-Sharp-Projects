using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Iterating_assignment
{
    class Program
    {
        static void Main()
        {
            // creating a array of strings then taking in user input
            string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            // adding the user input to the end of each string in our array
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = colors[i] + input;
            }
            // printing each item in the array
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            Console.ReadLine();

            // ---------------------------------------------------------------------
            // infinit loop
            //for (int i = 0; i < colors.Length || i >= colors.Length; i++)
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("Never going to give you up");
            }
            Console.ReadLine();

            // --------------------------------------------------------------------

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("COLORS!");
            }
            Console.ReadLine();

            // adding a math function to my condition
            for (int i = 0; i <= colors.Length + 2; i++)
            {
                Console.WriteLine("I can do that?");
            }
            Console.ReadLine();

            // ---------------------------------------------------------------------

            // creating a list and initialising it with data
            List<string> pieces = new List<string>() { "king", "queen", "bishop", "knight", "rook", "pawn" };
            Console.WriteLine("Please type the name of a chess piece");
            string userPiece = Console.ReadLine();

            //creating a condition to break our loop
            bool found = false;
            // running a foreach loop to search for your user input
            foreach (string piece in pieces)
            {
                if (piece.Contains(userPiece))
                {
                    int pieceIndex = pieces.IndexOf(piece); // using the IndexOf method to find our index
                    Console.WriteLine("The " + userPiece + " is located at index " + pieceIndex);
                    found = true; // if our loop is successful in finding the user input this will not trigger our error
                    break; // exiting our loop
                }
            }
            // this block will only trigger if your loop was not successful
            if (found == false)
            {
                Console.WriteLine("Your piece was not found.");
            }
            Console.ReadLine();

            // ---------------------------------------------------------------------------

            List<string> turtles = new List<string>() { "leonardo", "raphael", "donatello", "michelangelo", "raphael" };
            Console.WriteLine("Please type the name of a ninja turtle.");
            string userTurtle = Console.ReadLine();

            bool foundTurtle = false;
            // creating a variable to track what element we are on
            int turtleIndex = 0;
            foreach (string turtle in turtles)
            {
                // checking if our element is equal to our user input regaurdless of casing
                if (turtle.Equals(userTurtle, StringComparison.InvariantCultureIgnoreCase))
                {
                    // formating our response to the user
                    Console.WriteLine($"{userTurtle} located at {turtleIndex}");
                    foundTurtle = true;
                }
                // after we evaluate each element we are counting up the index
                turtleIndex++;
            }
            if (!foundTurtle)
            {
                Console.WriteLine("Your turtle was not found.");
            }
            Console.ReadLine();

            // ----------------------------------------------------------------------------

            List<string> characters = new List<string>() { "jack o-neill", "daniel jackson", "samantha carter", "teal'c", "jack o-neill" };
            Console.WriteLine("Please type the name of a StarGate SG1 character.");
            string userCharacter = Console.ReadLine();

            bool foundCharacter = false;
            int characterIndex = 0;
            // keeping track of how many times we have found this match
            int characterCount = 0;
            foreach (string character in characters)
            {
                if (character.Equals(userCharacter, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{userCharacter} located at {characterIndex}");
                    foundCharacter = true;
                    // adding to our character matches
                    characterCount++;
                    // adding responses to the use based on how many times we have seen this match
                    string addedResponse = characterCount < 1 ? "This is the first time match" :"This is the 2nd match";
                    Console.WriteLine(addedResponse);
                }
                characterIndex++;
            }
            if (!foundCharacter)
            {
                Console.WriteLine("Your character was not found.");
            }
            Console.ReadLine();
        }
    }
}
