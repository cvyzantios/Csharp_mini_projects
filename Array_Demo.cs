using System;

class Arraydemo
{
    static void Main()
    {
        char answer;

        do
        {
            Console.Write("Give the elements of the Array: ");

            int x = Convert.ToInt32(Console.ReadLine());

            // Definition of array
            int[] sample = new int[x];

            // Add elements in the array
            for (int i = 0; i < x; i++)
            {
                sample[i] = i;
            }

            // Print the elements with String Interpolation ($)
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"This is sample[{i}]: {sample[i]}");
            }

            // Ask the user if he wants to try again
            Console.Write("\nDo you want to try again? (Y/N): ");
            answer = Convert.ToChar(Console.ReadLine().ToUpper());

        } while (answer == 'Y');

        Console.WriteLine("\nProgram finished.");
    }
}
