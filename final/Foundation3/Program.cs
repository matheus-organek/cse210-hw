using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an address for the events
        Address eventAddress1 = new Address("730 E University Pkwy", "Provo", "Utah", "USA");
        Address eventAddress2 = new Address("60 North Temple", "Salt Lake City", "Utah", "USA");
        Address eventAddress3 = new Address("50 North Temple", "Salt Lake City", "Utah", "USA");

        // Create instances of each type of event
        Lecture lectureEvent = new Lecture("Walking with the Savior", "This event will have the theme “Walking with the Savior” to help those who are going through difficulties and need to feel the love of Jesus Christ in their lives. The event will feature personal experiences, testimonies and deep reflection on the scriptures.", 
                                            "2024-02-14", "8:00 PM", "Lecture", eventAddress1, "Matheus Organek", 200);

        Reception receptionEvent = new Reception("General Conference", "The General Conference of the Church of Jesus Christ of Latter-day Saints is coming, our leaders will tell us what the Father and His Son want us to know.", 
                                                "2024-04-07", "10:00 AM", "Reception", eventAddress2, "gereralconference@lds.com");

        Outdoor outdoorEvent = new Outdoor("Helping the next generation", "This event will take place outdoors and will feature themes to help young people begin to build their lives to follow the Savior. The event will feature games, talks, testimonials, personal experiences and lots of fun.",
                                            "2024-06-15", "3:00 PM", "Outdoor", eventAddress3, "Sunny day");


        int userChoice = -1;

        while (userChoice != 4)
        {
            // Clear the console screen.
            Console.Clear();

            // Display menu options.
            Console.WriteLine("Menu options:" +
                            "\n   1. Display the Lecture Event message" +
                            "\n   2. Display the Reception Event message" +
                            "\n   3. Display the Outdoor Event message" +
                            "\n   4. Quit");

            // Prompt the user to select an option from the menu.
            Console.Write("Select a choice from the menu: ");
            // Read the user's choice from the console.
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Console.Clear();

                // Generate marketing messages for each event and output their results to the screen
                Console.WriteLine("-----Lecture Event Messages-----");
                Console.WriteLine($"> Standard Details: \n{lectureEvent.StandardDetails()}");
                Console.WriteLine($"\n> Full Details: \n{lectureEvent.FullDetails()}");
                Console.WriteLine($"\n> Short Description: \n{lectureEvent.ShortDescription()}");
                Console.ReadLine(); // Keep the console window open until the user presses enter
            }

            else if (userChoice == 2)
            {
                Console.Clear();

                Console.WriteLine("-----Reception Event-----");
                Console.WriteLine($"> Standard Details: \n{receptionEvent.StandardDetails()}");
                Console.WriteLine($"\n> Full Details: \n{receptionEvent.FullDetails()}");
                Console.WriteLine($"\n> Short Description: \n{receptionEvent.ShortDescription()}");
                Console.ReadLine();
            }

            else if (userChoice == 3)
            {
                Console.Clear();

                Console.WriteLine("-----Outdoor Event-----");
                Console.WriteLine($"> Standard Details: \n{outdoorEvent.StandardDetails()}");
                Console.WriteLine($"\n> Full Details: \n{outdoorEvent.FullDetails()}");
                Console.WriteLine($"\n> Short Description: \n{outdoorEvent.ShortDescription()}");
                Console.ReadLine();
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("\nThank you for using our program!");
                break;
            }

            else
            {
                Console.WriteLine("Enter a valid option from the menu.");
            }
        }       
    }
}