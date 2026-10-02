using System;

// ============================================================
// SimpleQueue
//
// Η κλάση που υλοποιεί ένα Queue.
// The class that implements a Queue.
//
// Queue = FIFO
// First In, First Out
// ============================================================

class SimpleQueue
{
    // --------------------------------------------------------
    // Ο πίνακας που αποθηκεύει τους χαρακτήρες.
    // The array that stores the characters.
    // --------------------------------------------------------

    public char[] q;


    // --------------------------------------------------------
    // putloc = θέση εισαγωγής.
    // putloc = position used for inserting elements.
    //
    // getloc = θέση εξαγωγής.
    // getloc = position used for retrieving elements.
    // --------------------------------------------------------

    public int putloc, getloc;


    // ========================================================
    // Constructor
    // ========================================================

    public SimpleQueue(int size)
    {
        // Δημιουργούμε τον πίνακα.
        // Create the array.
        //
        // Το +1 υπάρχει επειδή η συγκεκριμένη
        // υλοποίηση αφήνει τη θέση 0 αχρησιμοποίητη.
        //
        // The +1 exists because this implementation
        // leaves position 0 unused.

        q = new char[size + 1];


        // Αρχικά δεν έχουμε αποθηκεύσει
        // ούτε έχουμε διαβάσει κάποιο στοιχείο.
        //
        // Initially, we have not stored
        // or retrieved any element.

        putloc = getloc = 0;
    }


    // ========================================================
    // Put()
    //
    // Βάζει έναν χαρακτήρα στο Queue.
    // Puts one character into the Queue.
    // ========================================================

    public void Put(char ch)
    {
        // Ελέγχουμε αν το Queue είναι γεμάτο.
        // Check if the Queue is full.

        if (putloc == q.Length - 1)
        {
            // Εμφανίζουμε μήνυμα.
            // Display a message.

            Console.WriteLine("-- Queue is full");


            // Σταματάμε τη μέθοδο.
            // Stop the method.

            return;
        }


        // Μετακινούμε το putloc μία θέση μπροστά.
        // Move putloc one position forward.

        putloc++;


        // Αποθηκεύουμε τον χαρακτήρα.
        // Store the character.

        q[putloc] = ch;
    }


    // ========================================================
    // Get()
    //
    // Παίρνει έναν χαρακτήρα από το Queue.
    // Retrieves one character from the Queue.
    // ========================================================

    public char Get()
    {
        // Ελέγχουμε αν το Queue είναι άδειο.
        // Check if the Queue is empty.

        if (getloc == putloc)
        {
            // Εμφανίζουμε μήνυμα.
            // Display a message.

            Console.WriteLine("-- Queue is empty");


            // Επιστρέφουμε ειδική τιμή.
            // Return a special value.

            return (char)0;
        }


        // Μετακινούμε το getloc μία θέση μπροστά.
        // Move getloc one position forward.

        getloc++;


        // Επιστρέφουμε τον χαρακτήρα.
        // Return the character.

        return q[getloc];
    }
}


// ============================================================
// QDemo
//
// Το Main() βρίσκεται εδώ.
// The Main() method is here.
// ============================================================

class QDemo
{
    static void Main()
    {
        // ====================================================
        // BIG QUEUE
        // ====================================================

        // Το bigQ έχει σταθερό μέγεθος 100.
        // bigQ has a fixed capacity of 100.

        SimpleQueue bigQ = new SimpleQueue(100);


        // ====================================================
        // Ζητάμε από τον χρήστη το μέγεθος του smallQ.
        //
        // Ask the user for the size of smallQ.
        // ====================================================

        Console.Write("How many positions do you want in smallQ? ");

        // Διαβάζουμε την απάντηση του χρήστη.
        // Read the user's answer.

        int size = Convert.ToInt32(Console.ReadLine());


        // ====================================================
        // Ζητάμε από τον χρήστη πόσα γράμματα
        // θέλει να προσπαθήσει να αποθηκεύσει.
        //
        // Ask the user how many letters
        // he wants to try to store.
        // ====================================================

        Console.Write("How many letters do you want to store? ");

        // Αποθηκεύουμε την απάντηση.
        // Store the answer.

        int numberOfLetters = Convert.ToInt32(Console.ReadLine());


        // ====================================================
        // ΔΗΜΙΟΥΡΓΙΑ ΤΟΥ SMALLQ
        // ====================================================

        // Δημιουργούμε το Queue
        // με το μέγεθος που έδωσε ο χρήστης.
        //
        // Create the Queue
        // using the size entered by the user.

        SimpleQueue smallQ = new SimpleQueue(size);


        // Μεταβλητή για χαρακτήρες.
        // Variable for characters.

        char ch;


        // Μεταβλητή counter για τα loops.
        // Counter variable for the loops.

        int i;


        // ====================================================
        // BIG QUEUE - ΑΠΟΘΗΚΕΥΣΗ ΑΛΦΑΒΗΤΟΥ
        //
        // BIG QUEUE - STORE THE ALPHABET
        // ====================================================

        Console.WriteLine();
        Console.WriteLine("Using bigQ to store the alphabet.");


        // Το αγγλικό αλφάβητο έχει 26 γράμματα.
        // The English alphabet has 26 letters.

        for (i = 0; i < 26; i++)
        {
            // Δημιουργούμε τα γράμματα A έως Z.
            // Create the letters A through Z.
            //
            // i = 0  → A
            // i = 1  → B
            // i = 2  → C
            // ...
            // i = 25 → Z

            bigQ.Put((char)('A' + i));
        }


        // Εμφανίζουμε τίτλο.
        // Display a title.

        Console.Write("Contents of bigQ: ");


        // Παίρνουμε τα 26 γράμματα από το Queue.
        // Retrieve the 26 letters from the Queue.

        for (i = 0; i < 26; i++)
        {
            // Παίρνουμε το επόμενο γράμμα.
            // Get the next letter.

            ch = bigQ.Get();


            // Ελέγχουμε αν είναι πραγματικός χαρακτήρας.
            // Check if it is a real character.

            if (ch != (char)0)
            {
                // Εμφανίζουμε το γράμμα.
                // Display the letter.

                Console.Write(ch);
            }
        }


        // Αλλαγή γραμμής.
        // New line.

        Console.WriteLine();
        Console.WriteLine();


        // ====================================================
        // SMALL QUEUE
        // ====================================================

        Console.WriteLine("Using smallQ to generate errors.");


        // Εμφανίζουμε τι επέλεξε ο χρήστης.
        // Display what the user selected.

        Console.WriteLine("Queue capacity: " + size);
        Console.WriteLine("Letters to store: " + numberOfLetters);

        Console.WriteLine();


        // ====================================================
        // ΑΠΟΘΗΚΕΥΣΗ ΓΡΑΜΜΑΤΩΝ
        //
        // STORE LETTERS
        // ====================================================

        // Το loop θα εκτελεστεί όσες φορές
        // ζήτησε ο χρήστης.
        //
        // The loop will execute as many times
        // as requested by the user.

        for (i = 0; i < numberOfLetters; i++)
        {
            // Υπολογίζουμε το γράμμα.
            // Calculate the letter.
            //
            // 0 → Z
            // 1 → Y
            // 2 → X
            // 3 → W
            // ...

            char letter = (char)('Z' - i);


            // Εμφανίζουμε τι προσπαθούμε να αποθηκεύσουμε.
            // Display what we are trying to store.

            Console.Write("Attempting to store " + letter);


            // Προσπαθούμε να βάλουμε το γράμμα στο Queue.
            // Try to put the letter into the Queue.

            smallQ.Put(letter);


            // Αλλαγή γραμμής.
            // New line.

            Console.WriteLine();
        }


        // Κενή γραμμή.
        // Empty line.

        Console.WriteLine();


        // ====================================================
        // ΑΝΑΚΤΗΣΗ ΓΡΑΜΜΑΤΩΝ
        //
        // RETRIEVE LETTERS
        // ====================================================

        Console.Write("Contents of smallQ: ");


        // Προσπαθούμε να πάρουμε
        // όσες τιμές προσπάθησε να αποθηκεύσει ο χρήστης.
        //
        // Try to retrieve as many values
        // as the user tried to store.

        for (i = 0; i < numberOfLetters; i++)
        {
            // Παίρνουμε το επόμενο γράμμα.
            // Get the next letter.

            ch = smallQ.Get();


            // Αν δεν είναι η ειδική τιμή (char)0,
            // τότε το εμφανίζουμε.
            //
            // If it is not the special value (char)0,
            // display it.

            if (ch != (char)0)
            {
                Console.Write(ch);
            }
        }


        // Τελική αλλαγή γραμμής.
        // Final new line.

        Console.WriteLine();
    }
}