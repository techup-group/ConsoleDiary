namespace ConsoleDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Diary");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a new entry");
                Console.WriteLine("2. List all entries");
                Console.WriteLine("3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddJournalEntry();
                        break;
                    case 2:
                        ListEntries();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void AddJournalEntry()
        {
            using (var context = new DiaryContext())
            {
                Console.Write("Enter title: ");
                string title = Console.ReadLine();

                Console.Write("Enter content: ");
                string content = Console.ReadLine();

                var question = new JournalEntries { Title = title, Content = content, CreatedAt = DateTime.Now };
                context.JournalEntries.Add(question);
                context.SaveChanges();

                Console.WriteLine($"Question '{title}' added successfully.");

                Console.WriteLine("\nDo you want to add another question? (Y/N)");
                string addAnother = Console.ReadLine().ToLower();

                if (addAnother == "y")
                {
                    AddJournalEntry();
                }
            }
        }

        static void ListEntries()
        {
            using (var context = new DiaryContext())
            {
                var journalEntries = context.JournalEntries.ToList();

                if (journalEntries.Any())
                {
                    Console.WriteLine("\nAll Entries:");
                    foreach (var entry in journalEntries)
                    {
                        Console.WriteLine($"{entry.Id}. {entry.Title}");
                    }
                }
                else
                {
                    Console.WriteLine("No entries found.");
                }
            }
        }
    }
}