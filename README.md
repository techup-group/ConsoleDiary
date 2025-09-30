# Creating a Console Diary App (Step-by-Step Guide)

This guide will walk you through the process of creating a simple console diary application similar to the one described in the provided code snippets. The application will allow users to add, list, and view journal entries.

## Prerequisites

- A basic understanding of C# programming language
- .NET 9.0 SDK or later installed on your machine
- A text editor or integrated development environment (IDE)

## Step 1: Create a new .NET console project

1. Open your terminal or command prompt.
2. Navigate to the directory where you want to create your project.
3. Run the following command to create a new .NET console project:

```bash
dotnet new console -n ConsoleDiary
```

## Step 2: Add necessary NuGet packages

1. Navigate to the project folder:

```bash
cd ConsoleDiary
```

2. Add the required NuGet packages for Entity Framework Core and SQL Server:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

## Step 3: Create the database model

1. In the `ConsoleDiary` folder, create a new folder named `Models`.
2. In the `Models` folder, create a new class named `JournalEntries.cs`.
3. Define the `JournalEntries` model with properties: `Id`, `Title`, `Content`, and `CreatedAt`.

## Step 4: Create the database context

1. In the `ConsoleDiary` folder, create a new file named `DiaryContext.cs`.
2. Define the `DiaryContext` class that inherits from `DbContext`.
3. Configure the database connection using the `OnConfiguring` method.
4. Define a `DbSet` property for the `JournalEntries` model.

## Step 5: Implement the main program logic

1. Open the `Program.cs` file in the `ConsoleDiary` folder.
2. Replace the existing code with a simple menu-driven interface.
3. Implement the `AddJournalEntry`, `ListEntries`, and `Exit` functions.

## Step 6: Run the application

1. Build the project by running the following command in the terminal:

```bash
dotnet build
```

2. Run the application by executing the following command:

```bash
dotnet run
```

Now you have a basic console diary application that allows users to add, list, and view journal entries.

# Using the Console Diary App

Once the application is running, you will see a menu with the following options:

1. Add a new entry
2. List all entries
3. Exit

Choose an option by entering the corresponding number and pressing Enter.

## Adding a new entry

1. Select option 1: "Add a new entry".
2. Enter the title for the journal entry.
3. Enter the content for the journal entry.
4. The entry will be saved to the database and displayed with a unique ID.

## Listing all entries

1. Select option 2: "List all entries".
2. All journal entries will be displayed with their unique IDs, titles, and creation dates.

## Exiting the application

1. Select option 3: "Exit".
2. The application will close.

That's it! You now have a simple console diary application that allows users to add, list, and view journal entries.
