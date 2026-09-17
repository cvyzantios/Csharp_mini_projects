using System;

class AssignARef
{
    static void Main()
    {
        int i; // Loop counter

        // Ask the user how many elements to use
        Console.Write("How many elements do you want to use? ");
        int x = Convert.ToInt32(Console.ReadLine());

        // Make sure the user does not exceed the array size
        if (x > 10)
        {
            Console.WriteLine("Maximum value is 10.");
            return;
        }

        // Create the first array
        int[] nums1 = new int[10];

        // Create the second array
        int[] nums2 = new int[10];

        // Fill nums1 with values from 0 to x-1
        for (i = 0; i < x; i++)
            nums1[i] = i;

        // Fill nums2 with negative values from 0 to -(x-1)
        for (i = 0; i < x; i++)
            nums2[i] = -i;

        // Display nums1
        Console.WriteLine("Here is nums1:");

        for (i = 0; i < x; i++)
            Console.Write(nums1[i] + " ");

        Console.WriteLine();
        Console.WriteLine();

        // Display nums2
        Console.WriteLine("Here is nums2:");

        for (i = 0; i < x; i++)
            Console.Write(nums2[i] + " ");

        Console.WriteLine();
        Console.WriteLine();

        // Assign the reference of nums1 to nums2
        // Both variables now point to the same array
        nums2 = nums1;

        // Display nums2 after reference assignment
        Console.WriteLine("Here is nums2 after reference assignment:");

        for (i = 0; i < x; i++)
            Console.Write(nums2[i] + " ");

        Console.WriteLine();
        Console.WriteLine();

        // Change one element through nums2
        nums2[3] = 99;

        // Display nums1 after changing it through nums2
        Console.WriteLine("Here is nums1 after change through nums2:");

        // The change is visible because nums1 and nums2
        // refer to the same array
        for (i = 0; i < x; i++)
            Console.Write(nums1[i] + " ");

        Console.WriteLine();
        Console.WriteLine();

        // End of the reference demonstration
        Console.WriteLine("Reference demonstration completed.");
    }
}