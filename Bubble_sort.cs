using System;                                      // Imports the System namespace

class Bubble                                        // Defines a class named Bubble
{
    static void Main()                              // Main method: program execution starts here
    {
        char answer;                                // Stores the user's answer for continuing

        do                                          // Starts the program and allows it to repeat
        {
            Console.Write("How many numbers do you want to sort? ");
                                                    // Asks the user how many numbers will be sorted

            int size = Convert.ToInt32(Console.ReadLine());
                                                    // Reads the user's input and converts it to an integer

            int[] nums = new int[size];             // Creates an integer array with the selected size

            for (int i = 0; i < size; i++)          // Loops through all array positions
            {
                Console.Write($"Enter number {i + 1}: ");
                                                    // Asks the user to enter a number

                nums[i] = Convert.ToInt32(Console.ReadLine());
                                                    // Stores the entered number in the array
            }

            Console.WriteLine("\nOriginal array is:");
                                                    // Displays a message before printing the original array

            for (int i = 0; i < size; i++)          // Loops through all array positions
            {
                Console.WriteLine(nums[i]);         // Prints the value stored at position i
            }

            int a, b, t;                            // Declares three integer variables: a, b and t

            for (a = 1; a < size; a++)              // Outer loop: controls the number of Bubble Sort passes
            {
                for (b = size - 1; b >= a; b--)     // Inner loop: compares adjacent elements from right to left
                {
                    if (nums[b - 1] > nums[b])      // Checks if the previous element is greater than the current one
                    {
                        t = nums[b - 1];            // Temporarily stores the previous element
                        nums[b - 1] = nums[b];      // Moves the smaller element to the previous position
                        nums[b] = t;                // Moves the larger element to the current position
                    }
                }
            }

            Console.WriteLine("\nSorted array is:");
                                                    // Displays a message before printing the sorted array

            for (int i = 0; i < size; i++)          // Loops through all array positions
            {
                Console.WriteLine(nums[i]);         // Prints the sorted value
            }

            Console.Write("\nDo you want to sort another array? (Y/N): ");
                                                    // Asks the user if they want to run the program again

            answer = Convert.ToChar(Console.ReadLine().ToUpper());
                                                    // Reads the answer, converts it to uppercase and stores it

        } while (answer == 'Y');                    // Repeats the program if the user entered Y

        Console.WriteLine("\nProgram finished.");   // Displays a message when the program ends
    }
}