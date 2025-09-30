namespace ConsoleDiary
{
    class Program
    {
        // Declare a static list to store journal entries
        private static List<JournalEntries> journalEntries = new List<JournalEntries>();

        static void Main(string[] args)
        {
            // Display the application title
            Console.WriteLine("Console Diary");

            // Start an infinite loop for the main menu
            while (true)
            {
                // Display menu options
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a new entry");
                Console.WriteLine("2. List all entries");
                Console.WriteLine("3. Exit");

                // Read user's choice and convert it to an integer
                int choice = Convert.ToInt32(Console.ReadLine());

                // Use a switch statement to handle user's choice
                switch (choice)
                {
                    case 1:
                        // Call method to add a new journal entry
                        AddJournalEntry();
                        break;
                    case 2:
                        // Call method to list all entries
                        ListEntries();
                        break;
                    case 3:
                        // Exit the application
                        return;
                    default:
                        // Handle invalid input
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void AddJournalEntry()
        {
            // Prompt user for entry title
            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            // Prompt user for entry content
            Console.Write("Enter content: ");
            string content = Console.ReadLine();

            // Create a new JournalEntries object with user input and current timestamp
            var question = new JournalEntries { Title = title, Content = content, CreatedAt = DateTime.Now };
            // Add the new entry to the list
            journalEntries.Add(question);

            // Confirm successful addition
            Console.WriteLine($"Question '{title}' added successfully.");

            // Ask if user wants to add another entry
            Console.WriteLine("\nDo you want to add another question? (Y/N)");
            string addAnother = Console.ReadLine().ToLower();

            // If user wants to add another, call this method recursively
            if (addAnother == "y")
            {
                AddJournalEntry();
            }
        }

        static void ListEntries()
        {
            // Check if there are any entries in the list
            if (journalEntries.Any())
            {
                // Display header for entries list
                Console.WriteLine("\nAll Entries:");
                // Iterate through each entry and display its title
                foreach (var entry in journalEntries)
                {
                    Console.WriteLine($"{entry.Title}");
                }
            }
            else
            {
                // Inform user if no entries are found
                Console.WriteLine("No entries found.");
            }
        }
    }
}