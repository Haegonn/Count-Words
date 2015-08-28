using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduce the program to the user.
            Console.WriteLine("Welcome to Josh's Word Counter 1000!");

            // Prompt the user to enter the string they would like counted.
            Console.WriteLine("Please enter the string which you would like the words counted: ");
            String originalString = Console.ReadLine();

            // Set up the wordCount variable, which will be used to keep track of how many words we have.
            int wordCount = 0;

            // Loop over originalString and look for spaces.
            foreach (char c in originalString)
            {
                if (c == ' ')
                {
                    wordCount++;
                }
            }

            // Add 1 to wordCount to make up for the very last word.
            wordCount += 1;

            // Display the word count.
            Console.WriteLine("Your word count is: {0}", wordCount);

            // Pause the console so the user can see the output.
            Console.WriteLine("Please press enter to exit the program. :)");
            Console.ReadLine();
        }
    }
}
