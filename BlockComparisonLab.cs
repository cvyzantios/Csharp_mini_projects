

using System;
// Imports the System namespace, which contains Console.
// Εισάγουμε το namespace System, που περιέχει την Console.




class Block
// Defines the Block class.
// Ορίζουμε την κλάση Block.
{
    int a, b, c;
    // Stores the three dimensions of the block.
    // Αποθηκεύει τις τρεις διαστάσεις του παραλληλεπιπέδου.

    int volume;
    // Stores the volume of the block.
    // Αποθηκεύει τον όγκο του παραλληλεπιπέδου.

    public Block(int i, int j, int k)
    // Constructor that initializes a new Block object.
    // Constructor που αρχικοποιεί ένα νέο αντικείμενο Block.
    {
        a = i;
        // Assigns the first dimension.
        // Αναθέτει την πρώτη διάσταση.

        b = j;
        // Assigns the second dimension.
        // Αναθέτει τη δεύτερη διάσταση.

        c = k;
        // Assigns the third dimension.
        // Αναθέτει την τρίτη διάσταση.

        volume = a * b * c;
        // Calculates the volume.
        // Υπολογίζει τον όγκο.
    }

    public bool SameBlock(Block ob)
    // Checks whether two blocks have identical dimensions.
    // Ελέγχει αν δύο αντικείμενα έχουν ίδιες διαστάσεις.
    {
        if ((ob.a == a) && (ob.b == b) && (ob.c == c))
        // All three dimensions must be equal.
        // Πρέπει να είναι ίσες και οι τρεις διαστάσεις.
        {
            return true;
            // Returns true if all dimensions match.
            // Επιστρέφει true αν όλες οι διαστάσεις είναι ίδιες.
        }
        else
        {
            return false;
            // Returns false if any dimension differs.
            // Επιστρέφει false αν διαφέρει κάποια διάσταση.
        }
    }

    public bool SameVolume(Block ob)
    // Checks whether two blocks have the same volume.
    // Ελέγχει αν δύο αντικείμενα έχουν τον ίδιο όγκο.
    {
        if (ob.volume == volume)
        // Compares the two volume values.
        // Συγκρίνει τις δύο τιμές του όγκου.
        {
            return true;
            // The volumes are equal.
            // Οι όγκοι είναι ίσοι.
        }
        else
        {
            return false;
            // The volumes are different.
            // Οι όγκοι είναι διαφορετικοί.
        }
    }
}

class PassOb
// Defines the class containing Main and the helper methods.
// Ορίζει την κλάση που περιέχει τη Main και τις βοηθητικές μεθόδους.
{
    static int ReadDimension(string prompt)
    // Reads a valid positive integer from the user.
    // Διαβάζει έναν έγκυρο θετικό ακέραιο από τον χρήστη.
    {
        int number;
        // Stores the number entered by the user.
        // Αποθηκεύει τον αριθμό που εισάγει ο χρήστης.

        while (true)
        // Repeats until the user enters a valid dimension.
        // Επαναλαμβάνει μέχρι ο χρήστης να δώσει έγκυρη διάσταση.
        {
            Console.Write(prompt);
            // Displays the question.
            // Εμφανίζει την ερώτηση.

            string input = Console.ReadLine();
            // Reads the user's input as text.
            // Διαβάζει την είσοδο του χρήστη ως κείμενο.

            if (int.TryParse(input, out number) && number > 0)
            // Checks whether the input is an integer greater than zero.
            // Ελέγχει αν η είσοδος είναι ακέραιος μεγαλύτερος από το μηδέν.
            {
                return number;
                // Returns the valid dimension.
                // Επιστρέφει την έγκυρη διάσταση.
            }

            Console.WriteLine("Invalid input! Enter a positive integer.");
            // Displays an error message.
            // Εμφανίζει μήνυμα λάθους.

            Console.WriteLine("Μη έγκυρη είσοδος! Δώσε θετικό ακέραιο.");
            // Displays the error message in Greek.
            // Εμφανίζει το μήνυμα λάθους στα Ελληνικά.
        }
    }

    static bool AskTryAgain()
    // Asks whether the user wants to repeat the program.
    // Ρωτά αν ο χρήστης θέλει να επαναλάβει το πρόγραμμα.
    {
        while (true)
        // Repeats until the user enters y or n.
        // Επαναλαμβάνει μέχρι ο χρήστης να δώσει y ή n.
        {
            Console.Write("\nDo you want to try again? (y/n): ");
            // Asks the user whether to try again.
            // Ρωτά τον χρήστη αν θέλει να ξαναδοκιμάσει.

            string answer = Console.ReadLine().Trim().ToLower();
            // Removes surrounding spaces and converts to lowercase.
            // Αφαιρεί τα περιττά κενά και μετατρέπει σε πεζά γράμματα.

            if (answer == "y")
            // Checks whether the user wants to continue.
            // Ελέγχει αν ο χρήστης θέλει να συνεχίσει.
            {
                return true;
                // Returns true to repeat the program.
                // Επιστρέφει true για επανάληψη του προγράμματος.
            }

            if (answer == "n")
            // Checks whether the user wants to exit.
            // Ελέγχει αν ο χρήστης θέλει να τερματίσει.
            {
                return false;
                // Returns false to stop the repetition.
                // Επιστρέφει false για να σταματήσει η επανάληψη.
            }

            Console.WriteLine("Please enter y or n.");
            // Rejects any other answer.
            // Απορρίπτει οποιαδήποτε άλλη απάντηση.
        }
    }

    static void Main()
    // The main entry point of the program.
    // Το κύριο σημείο εκκίνησης του προγράμματος.
    {
        
        Console.WriteLine("========================================");
Console.WriteLine("       BlockComparisonLab");
Console.WriteLine("========================================");
Console.WriteLine("Compares dimensions and volumes of blocks.");
Console.WriteLine("Συγκρίνει διαστάσεις και όγκους παραλληλεπιπέδων.");
Console.WriteLine("========================================\n");
        
        bool tryAgain;
        // Stores whether another attempt is requested.
        // Αποθηκεύει αν ζητήθηκε νέα προσπάθεια.

        do
        // Executes the program at least once.
        // Εκτελεί το πρόγραμμα τουλάχιστον μία φορά.
        {
            Console.WriteLine("\n=== BLOCK COMPARISON ===");
            // Displays the program title.
            // Εμφανίζει τον τίτλο του προγράμματος.

            Console.WriteLine("\nEnter dimensions for the first block:");
            // Requests the first block's dimensions.
            // Ζητά τις διαστάσεις του πρώτου αντικειμένου.

            int x1 = ReadDimension("Give the first dimension: ");
            // Reads the first dimension of block 1.
            // Διαβάζει την πρώτη διάσταση του αντικειμένου 1.

            int y1 = ReadDimension("Give the second dimension: ");
            // Reads the second dimension of block 1.
            // Διαβάζει τη δεύτερη διάσταση του αντικειμένου 1.

            int z1 = ReadDimension("Give the third dimension: ");
            // Reads the third dimension of block 1.
            // Διαβάζει την τρίτη διάσταση του αντικειμένου 1.

            Block ob1 = new Block(x1, y1, z1);
            // Creates the first block.
            // Δημιουργεί το πρώτο αντικείμενο.

            Console.WriteLine("\nEnter dimensions for the second block:");
            // Requests the second block's dimensions.
            // Ζητά τις διαστάσεις του δεύτερου αντικειμένου.

            int x2 = ReadDimension("Give the first dimension: ");
            // Reads the first dimension of block 2.
            // Διαβάζει την πρώτη διάσταση του αντικειμένου 2.

            int y2 = ReadDimension("Give the second dimension: ");
            // Reads the second dimension of block 2.
            // Διαβάζει τη δεύτερη διάσταση του αντικειμένου 2.

            int z2 = ReadDimension("Give the third dimension: ");
            // Reads the third dimension of block 2.
            // Διαβάζει την τρίτη διάσταση του αντικειμένου 2.

            Block ob2 = new Block(x2, y2, z2);
            // Creates the second block.
            // Δημιουργεί το δεύτερο αντικείμενο.

            Console.WriteLine("\nEnter dimensions for the third block:");
            // Requests the third block's dimensions.
            // Ζητά τις διαστάσεις του τρίτου αντικειμένου.

            int x3 = ReadDimension("Give the first dimension: ");
            // Reads the first dimension of block 3.
            // Διαβάζει την πρώτη διάσταση του αντικειμένου 3.

            int y3 = ReadDimension("Give the second dimension: ");
            // Reads the second dimension of block 3.
            // Διαβάζει τη δεύτερη διάσταση του αντικειμένου 3.

            int z3 = ReadDimension("Give the third dimension: ");
            // Reads the third dimension of block 3.
            // Διαβάζει την τρίτη διάσταση του αντικειμένου 3.

            Block ob3 = new Block(x3, y3, z3);
            // Creates the third block.
            // Δημιουργεί το τρίτο αντικείμενο.

            Console.WriteLine("\n=== COMPARISONS ===");
            // Displays the comparison section.
            // Εμφανίζει την ενότητα συγκρίσεων.

            Console.WriteLine("ob1 same dimensions as ob2: " + ob1.SameBlock(ob2));
            // Compares the dimensions of blocks 1 and 2.
            // Συγκρίνει τις διαστάσεις των αντικειμένων 1 και 2.

            Console.WriteLine("ob1 same dimensions as ob3: " + ob1.SameBlock(ob3));
            // Compares the dimensions of blocks 1 and 3.
            // Συγκρίνει τις διαστάσεις των αντικειμένων 1 και 3.

            Console.WriteLine("ob2 same dimensions as ob3: " + ob2.SameBlock(ob3));
            // Compares the dimensions of blocks 2 and 3.
            // Συγκρίνει τις διαστάσεις των αντικειμένων 2 και 3.

            Console.WriteLine("ob1 same volume as ob2: " + ob1.SameVolume(ob2));
            // Compares the volumes of blocks 1 and 2.
            // Συγκρίνει τους όγκους των αντικειμένων 1 και 2.

            Console.WriteLine("ob1 same volume as ob3: " + ob1.SameVolume(ob3));
            // Compares the volumes of blocks 1 and 3.
            // Συγκρίνει τους όγκους των αντικειμένων 1 και 3.

            Console.WriteLine("ob2 same volume as ob3: " + ob2.SameVolume(ob3));
            // Compares the volumes of blocks 2 and 3.
            // Συγκρίνει τους όγκους των αντικειμένων 2 και 3.

            tryAgain = AskTryAgain();
            // Asks whether the user wants another attempt.
            // Ρωτά αν ο χρήστης θέλει άλλη μία προσπάθεια.

        } while (tryAgain);
        // Repeats while tryAgain is true.
        // Επαναλαμβάνει όσο το tryAgain είναι true.

        Console.WriteLine("\nGoodbye!");
        // Displays a goodbye message.
        // Εμφανίζει μήνυμα αποχαιρετισμού.
    }
}

/*
==========================================================
REPORT: BLOCK COMPARISON PROGRAM
ΑΝΑΦΟΡΑ: ΠΡΟΓΡΑΜΜΑ ΣΥΓΚΡΙΣΗΣ ΠΑΡΑΛΛΗΛΕΠΙΠΕΔΩΝ
==========================================================

1. CLASS AND CONSTRUCTOR / ΚΛΑΣΗ ΚΑΙ CONSTRUCTOR

The Block class stores three dimensions and calculates
the volume of each object.

Η κλάση Block αποθηκεύει τρεις διαστάσεις και υπολογίζει
τον όγκο κάθε αντικειμένου.

Volume = a * b * c
Όγκος = a * b * c


2. COMPARISON METHODS / ΜΕΘΟΔΟΙ ΣΥΓΚΡΙΣΗΣ

SameBlock() compares the dimensions of two objects.
Η SameBlock() συγκρίνει τις διαστάσεις δύο αντικειμένων.

SameVolume() compares the volumes of two objects.
Η SameVolume() συγκρίνει τους όγκους δύο αντικειμένων.

Both methods return true or false.
Και οι δύο μέθοδοι επιστρέφουν true ή false.


3. INPUT VALIDATION / ΕΛΕΓΧΟΣ ΕΙΣΟΔΟΥ

ReadDimension() uses int.TryParse() to validate input
and accepts only positive integers.

Η ReadDimension() χρησιμοποιεί int.TryParse() για τον
έλεγχο της εισόδου και δέχεται μόνο θετικούς ακεραίους.

Invalid input does not terminate the program.
Η μη έγκυρη είσοδος δεν τερματίζει το πρόγραμμα.


4. REPETITION / ΕΠΑΝΑΛΗΨΗ

AskTryAgain() asks the user to enter y or n.

Η AskTryAgain() ζητά από τον χρήστη να εισαγάγει y ή n.

The do-while loop repeats the comparison process
when the user enters y and stops when the user enters n.

Ο βρόχος do-while επαναλαμβάνει τη διαδικασία σύγκρισης
όταν ο χρήστης εισάγει y και σταματά όταν εισάγει n.


5. MAIN CONCEPT / ΒΑΣΙΚΗ ΙΔΕΑ

The program combines classes, objects, constructors,
Boolean methods, input validation and repetition.

Το πρόγραμμα συνδυάζει κλάσεις, αντικείμενα, constructors,
μεθόδους Boolean, έλεγχο εισόδου και επανάληψη.

==========================================================
*/
