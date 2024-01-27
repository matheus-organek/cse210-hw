// For the strecht challange, I tried to implement the HideRandomWords() only for the words that are not already hidden, 
// as suggested in the activity description.
// In this case, in the while loop the instruction checks whether the word is already hidden. If yes, it just moves to the next one, otherwise it hides and adds increments.

using System;
class Program
{
    static void Main(string[] args)
    {   
        // Instances for Reference and Scripture Class.
        Reference reference = new Reference("D&C", 121, 7, 8);
        Scripture scripture = new Scripture(reference, "\n7. My son, peace be unto thy soul; thine adversity and thine afflictions shall be but a small moment;\n8. And then, if thou endure it well, God shall exalt thee on high; thou shalt triumph over all thy foes.");
        
        // A Welcome Message.
        Console.WriteLine("\nWelcome to the Scripture Memorizer Demo!");

        // Display the scripture.
        Console.WriteLine(scripture.GetDisplayText());

        // A variable 'loop' o enter into while loop.
        bool loop = true;
        
        // A while loop begins.
        while(loop)
        {
            // A message is displayed to guide the user.
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            // The variable 'input' is created to lead with the user response.
            // Using the Trim() method no eliminate blank spaces.
            string input = Console.ReadLine().Trim();

            // An if statement to lead with the 'quit' user's response.
            if(input.ToLower() == "quit")
            {
                // An exit program message is displayed.
                Console.WriteLine("\nThank you for using our program!");
                // The while loop ends.
                loop = false;
            }

            // But if anything else is entered by the user:
            else
            {
                // One word is hidden.
                scripture.HideRandomWords(3);
                // The console is clean.
                Console.Clear();
                // And the scripture is displayed in the console again with one word hidden.
                Console.WriteLine(scripture.GetDisplayText());

                // To lead ff all the words are hidden.
                if(scripture.IsCompletelyHidden())
                {
                    // In this case, a message is displayed.
                    Console.WriteLine("\nAll words are hidden.\nThank you for using!");
                    // And the while loop comes to end.
                    loop = false;
                }
            }
        }
    }
}