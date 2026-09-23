
/*
Technical Report: Dynamic Queue in C#
1. Program Purpose
This program implements a Queue data structure following the FIFO (First-In, First-Out) principle. It allows the user to:
•	Dynamically define the size of the queue at runtime.
•	Insert characters with overflow checking.
•	Retrieve and display elements in the exact order they were inserted.
•	Safely interact with the program through input validation.
2. Architecture & Code Structure
A. Class SimpleQueue
Manages the data storage and queue logic.
•	q (char[]): The array storing the elements. Allocated with size + 1 elements since index 0 serves as an initial offset.
•	putloc: Index representing the location of the last inserted element.
•	getloc: Index representing the location of the last retrieved element.
•	Put(char ch): Inserts an element by incrementing putloc. If putloc == q.Length - 1, it signals a queue overflow.
•	Get(): Retrieves an element by incrementing getloc. If getloc == putloc, the queue is empty and returns (char)0.
B. Class SafeDynamicQueueDemo
Controls the execution flow and user input/output.
•	Main():
1.	Prompts for the queue size.
2.	Instantiates the SimpleQueue object.
3.	Reads the requested number of characters and pushes them using Put().
4.	Continuously calls Get() to read and print elements until the queue is empty.
•	ReadPositiveInteger(): Helper method utilizing int.TryParse() to prevent application crashes caused by invalid user inputs (e.g., entering letters instead of numbers).
3. Advantages & Limitations
Advantages	Limitations
Robust Input Handling: Prevents crashes using int.TryParse().	Linear Memory: Space freed by Get() cannot be reused (non-circular).
Dynamic Sizing: Array size configured at runtime by the user.	Type Constraint: Designed exclusively for char primitive types. */

using System; // Required for core C# functionality, such as Console I/O.

// Defines the SimpleQueue class, acting as a template for creating queue data structures.
class SimpleQueue
{
    public char[] q;           // Array storing the queue elements.
    public int putloc, getloc; // Pointers: putloc tracks insertions, getloc tracks retrievals.

    // Constructor: Runs automatically when a new queue instance is created.
    public SimpleQueue(int size)
    {
        q = new char[size + 1]; // Allocate array memory for size + 1 elements (index 0 is unused).
        putloc = getloc = 0;    // Initialize both pointers to 0 for an empty queue.
    }

    // Method to insert (Put) a character into the queue.
    public void Put(char ch)
    {
        // Check if the insertion pointer reached the end of the array.
        if (putloc == q.Length - 1)
        {
            Console.WriteLine($"-- Queue is full! Cannot store '{ch}'."); // Display overflow warning.
            return; // Exit method without storing the element.
        }

        putloc++;       // Advance the insertion pointer by 1.
        q[putloc] = ch; // Store the character at the new index.
    }

    // Method to retrieve (Get) a character from the queue.
    public char Get()
    {
        // Check if the retrieval pointer matches the insertion pointer.
        if (getloc == putloc)
        {
            Console.WriteLine("-- Queue is empty."); // Display underflow warning.
            return (char)0; // Return null character to signal an empty queue.
        }

        getloc++;        // Advance the retrieval pointer by 1.
        return q[getloc]; // Return the character stored at the current index.
    }
}

// Main application class containing the program entry point.
class SafeDynamicQueueDemo
{
    // The Main method serves as the starting point of execution.
    static void Main()
    {
        // Safely prompt and retrieve the desired queue size from the user.
        int queueSize = ReadPositiveInteger("Enter queue size: ");

        // Instantiate a new SimpleQueue object with the specified size.
        SimpleQueue myQueue = new SimpleQueue(queueSize);

        // Display a confirmation message.
        Console.WriteLine($"\nCreated a queue with a capacity of {queueSize} elements.\n");

        // Prompt and retrieve the number of characters the user wishes to enter.
        int count = ReadPositiveInteger("How many characters do you want to enter? ");

        Console.WriteLine(); // Print a blank line for output readability.

        // Loop to accept the user-defined number of characters.
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter character #{i + 1}: ");
            string input = Console.ReadLine(); // Read user input as a string.

            // Handle empty inputs (e.g., if the user just presses Enter).
            while (string.IsNullOrEmpty(input))
            {
                Console.Write("No character entered! Please try again: ");
                input = Console.ReadLine(); // Re-read input until valid.
            }

            // Take the first character of the input string and push it to the queue.
            myQueue.Put(input[0]);
        }

        // Display heading for queue extraction.
        Console.WriteLine("\n--- Queue Contents (Retrieving via Get) ---");
        Console.Write("Queue elements: ");

        char ch; // Temporary variable to store retrieved characters.

        // Continuously pull items from the queue until Get() returns (char)0.
        while ((ch = myQueue.Get()) != (char)0)
        {
            Console.Write(ch + " "); // Print each character separated by a space.
        }

        // Signal completion of program execution.
        Console.WriteLine("\n\nProgram finished.");
    }

    // Helper function to guarantee safe reading of positive integers.
    static int ReadPositiveInteger(string prompt)
    {
        int number;
        Console.Write(prompt);

        // Repeat prompt if input parsing fails or if value is less than or equal to 0.
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("-- Invalid input! Please enter a positive integer.");
            Console.Write(prompt);
        }

        return number; // Return validated integer value.
    }
}