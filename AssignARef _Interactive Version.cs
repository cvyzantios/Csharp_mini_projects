using System;

class AssignARef
{
    static void Main()
    {
        int i;

        int[] nums1 = new int[10];     // Create the first array
        int[] nums2 = new int[10];     // Create the second array

        // Fill nums1 with values from 0 to 9
        for (i = 0; i < 10; i++)
            nums1[i] = i;

        // Fill nums2 with values from 0 to 9
        for (i = 0; i < 10; i++)
            nums2[i] = i;

        Console.WriteLine("Here is nums1:");

        // Display nums1
        for (i = 0; i < 10; i++)
            Console.WriteLine(nums1[i] + "");

        Console.WriteLine();

        Console.WriteLine("Here is nums2:");

        // Display nums2
        for (i = 0; i < 10; i++)
            Console.WriteLine(nums2[i] + "");

        Console.WriteLine();

        // Assign the reference of nums1 to nums2
        nums2 = nums1;

        Console.WriteLine("Here is nums2 after assignment:");

        // Display nums2
        for (i = 0; i < 10; i++)
            Console.Write(nums2[i] + "");

        Console.WriteLine();

        // Change the fourth element through nums2
    
    Console.Write("What position of element you want to change : ");
    string input = Console.ReadLine();
    int position = int.Parse(input); 
    
    Console.Write("What number you want to put : ");
    string input2 = Console.ReadLine(); // New name of variable
    int number = int.Parse(input2);
    
    nums2[position] = number;

        Console.WriteLine("Here is nums1 after change through nums2:");

        // Display nums1
        for (i = 0; i < 10; i++)
            Console.Write(nums1[i] + "");

        Console.WriteLine();
    }
}
