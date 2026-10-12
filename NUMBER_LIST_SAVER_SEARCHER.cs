
using System;
using System.Collections.Generic;

// ============================================================
// NUMBER LIST SAVER SEARCHER
// ΑΠΟΘΗΚΕΥΣΗ ΚΑΙ ΑΝΑΖΗΤΗΣΗ ΑΡΙΘΜΩΝ ΣΕ ΛΙΣΤΑ
// ============================================================

class NumberListSaverSearcher
{
    static void Main()
    {
        // ====================================================
        // TECHNIQUE 1: DYNAMIC LIST CREATION
        // ΤΕΧΝΙΚΗ 1: ΔΥΝΑΜΙΚΗ ΔΗΜΙΟΥΡΓΙΑ ΛΙΣΤΑΣ
        // ====================================================

        // Create an empty list to store integers.
        // Δημιουργούμε μια κενή λίστα για αποθήκευση ακεραίων.
        List<int> myList = new List<int>();

        // Repeat the process of entering numbers.
        // Επαναλαμβάνουμε τη διαδικασία εισαγωγής αριθμών.
        while (true)
        {
            // Ask for a number or q to quit.
            // Ζητάμε έναν αριθμό ή q για έξοδο.
            Console.Write("Enter an integer (or q to quit): ");

            // Read the input, remove surrounding spaces
            // and convert letters to lowercase.
            // Διαβάζουμε την είσοδο, αφαιρούμε τα περιττά κενά
            // και μετατρέπουμε τα γράμματα σε πεζά.
            string userInput = Console.ReadLine().Trim().ToLower();

            // Check whether the user wants to stop.
            // Ελέγχουμε αν ο χρήστης θέλει να σταματήσει.
            if (userInput == "q")
            {
                break;
            }

            // Try to convert the input into an integer.
            // Προσπαθούμε να μετατρέψουμε την είσοδο σε ακέραιο.
            if (int.TryParse(userInput, out int num))
            {
                // Add the number to the end of the list.
                // Προσθέτουμε τον αριθμό στο τέλος της λίστας.
                myList.Add(num);
            }
            else
            {
                // Display an error message for invalid input.
                // Εμφανίζουμε μήνυμα λάθους για μη έγκυρη είσοδο.
                Console.WriteLine(
                    "Error! Please enter a valid integer. Try again!");

                // Return to the beginning of the loop.
                // Επιστρέφουμε στην αρχή του βρόχου.
                continue;
            }

            // Ask whether the user wants to add another number.
            // Ρωτάμε αν ο χρήστης θέλει να προσθέσει άλλον αριθμό.
            Console.Write("Do you want to add another number? (y/n): ");

            string again = Console.ReadLine().Trim().ToLower();

            // If the answer is not y, stop entering numbers.
            // Αν η απάντηση δεν είναι y, σταματάμε την εισαγωγή.
            if (again != "y")
            {
                break;
            }
        }

        // ====================================================
        // DISPLAY THE LIST
        // ΕΜΦΑΝΙΣΗ ΤΗΣ ΛΙΣΤΑΣ
        // ====================================================

        // Display all the numbers stored in the list.
        // Εμφανίζουμε όλους τους αριθμούς της λίστας.
        Console.WriteLine("\nYour list: " + string.Join(", ", myList));

        // ====================================================
        // TECHNIQUE 2: LIST SEARCH
        // ΤΕΧΝΙΚΗ 2: ΑΝΑΖΗΤΗΣΗ ΣΤΗ ΛΙΣΤΑ
        // ====================================================

        // Repeat the search process until the user quits.
        // Επαναλαμβάνουμε την αναζήτηση μέχρι να επιλέξει έξοδο.
        while (true)
        {
            // Ask whether the user wants to search or quit.
            // Ζητάμε y για αναζήτηση ή q για έξοδο.
            Console.Write("\nDo you want to search for a number? (y/q): ");

            string searchAgain = Console.ReadLine().Trim().ToLower();

            // If the user enters q, terminate the search.
            // Αν ο χρήστης εισαγάγει q, τερματίζουμε την αναζήτηση.
            if (searchAgain == "q")
            {
                Console.WriteLine("Goodbye! :)");
                break;
            }

            // Accept only y or q.
            // Δεχόμαστε μόνο y ή q.
            if (searchAgain != "y")
            {
                Console.WriteLine(
                    "Invalid choice! Enter y or q. Try again!");

                // Ask the question again.
                // Ξαναρωτάμε τον χρήστη.
                continue;
            }

            // Ask for the number to search for.
            // Ζητάμε τον αριθμό που θέλουμε να αναζητήσουμε.
            Console.Write("Enter the number to search for: ");

            string searchInput = Console.ReadLine().Trim();

            // Check whether the input is a valid integer.
            // Ελέγχουμε αν η είσοδος είναι έγκυρος ακέραιος.
            if (!int.TryParse(searchInput, out int searchNum))
            {
                // Display an error message.
                // Εμφανίζουμε μήνυμα λάθους.
                Console.WriteLine(
                    "Error! Please enter a valid integer. Try again!");

                // Return to the beginning of the search loop.
                // Επιστρέφουμε στην αρχή του βρόχου αναζήτησης.
                continue;
            }

            // Check whether the number exists in the list.
            // Ελέγχουμε αν ο αριθμός υπάρχει στη λίστα.
            if (myList.Contains(searchNum))
            {
                // Inform the user that the number exists.
                // Ενημερώνουμε τον χρήστη ότι ο αριθμός υπάρχει.
                Console.WriteLine(
                    $"The number {searchNum} exists in the list.");
            }
            else
            {
                // Inform the user that the number does not exist.
                // Ενημερώνουμε τον χρήστη ότι ο αριθμός δεν υπάρχει.
                Console.WriteLine(
                    $"The number {searchNum} does not exist in the list.");
            }

            // Ask whether the user wants another search.
            // Ρωτάμε αν ο χρήστης θέλει άλλη αναζήτηση.
            Console.Write("Search again? (y/q): ");

            string again = Console.ReadLine().Trim().ToLower();

            // If the user enters q, terminate the program.
            // Αν ο χρήστης εισαγάγει q, τερματίζουμε το πρόγραμμα.
            if (again == "q")
            {
                Console.WriteLine("Goodbye! :)");
                break;
            }

            // If the answer is not y, display an error message.
            // Αν η απάντηση δεν είναι y, εμφανίζουμε μήνυμα λάθους.
            if (again != "y")
            {
                Console.WriteLine(
                    "Invalid choice! Enter y or q. Try again!");
            }
        }
    }
}
