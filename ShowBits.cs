
using System;

// Defines a class that displays numbers in binary format.
// Ορίζει μια κλάση που εμφανίζει αριθμούς σε δυαδική μορφή.
class ShowBits
{
    public int numbits;

    // Constructor: initializes the number of bits.
    // Constructor: αρχικοποιεί τον αριθμό των bits.
    public ShowBits(int n)
    {
        numbits = n;
    }

    public void Show(ulong val)
    // Displays the binary representation of a number.
    // Εμφανίζει τη δυαδική αναπαράσταση ενός αριθμού.
    {
        ulong mask = 1UL;

        // Determines how many bits of the ulong value will be displayed.
        // Καθορίζει πόσα bits της τιμής ulong θα εμφανιστούν.
        int bitsToDisplay = Math.Min(numbits, 64);

        // Moves the mask to the highest bit position.
        // Μετακινεί τη μάσκα στην υψηλότερη θέση bit.
        mask <<= bitsToDisplay - 1;

        int spacer = 0;

        // For 128 bits, print 64 leading zeros first.
        // Για τα 128 bits, εμφανίζουμε πρώτα 64 αρχικά μηδενικά.
        for (int j = 0; j < numbits - bitsToDisplay; j++)
        {
            Console.Write("0");
            spacer++;

            if (spacer % 8 == 0)
            {
                Console.Write(" ");
            }
        }

        // Moves the mask one position to the right after each iteration.
        // Μετακινεί τη μάσκα μία θέση δεξιά σε κάθε επανάληψη.
        for (; mask != 0; mask >>= 1)
        {
            // Checks whether the selected bit is 1.
            // Ελέγχει αν το επιλεγμένο bit είναι 1.
            if ((val & mask) != 0)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }

            spacer++;

            // Prints a space after every group of eight bits.
            // Εμφανίζει κενό μετά από κάθε ομάδα οκτώ bits.
            if (spacer % 8 == 0)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Creates four objects with different bit lengths.
        // Δημιουργεί τέσσερα αντικείμενα με διαφορετικό αριθμό bits.
        ShowBits b = new ShowBits(8);
        ShowBits i = new ShowBits(32);
        ShowBits li = new ShowBits(64);
        ShowBits xli = new ShowBits(128);

        bool repeat;

        do
        {
            ulong x;

            // Requests a number from the user.
            // Ζητά έναν αριθμό από τον χρήστη.
            Console.Write("\nEnter an unsigned integer: ");

            // Validates the user's input.
            // Ελέγχει αν η εισαγωγή του χρήστη είναι έγκυρη.
            while (!ulong.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Invalid input! Enter a valid unsigned integer: ");
            }

            Console.WriteLine("\n8-bit representation:");
            b.Show(x);

            Console.WriteLine("\n32-bit representation:");
            i.Show(x);

            Console.WriteLine("\n64-bit representation:");
            li.Show(x);

            Console.WriteLine("\n128-bit representation:");
            xli.Show(x);

            string answer;

            // Asks whether the user wants to enter another number.
            // Ρωτά αν ο χρήστης θέλει να εισαγάγει άλλον αριθμό.
            do
            {
                Console.Write("\nDo you want to enter another number? (Y/N): ");
                answer = Console.ReadLine().Trim().ToLower();

                // Accepts only valid Yes/No answers.
                // Δέχεται μόνο έγκυρες απαντήσεις Ναι/Όχι.
                if (answer != "y" && answer != "yes" &&
                    answer != "n" && answer != "no" &&
                    answer != "ν" && answer != "ναι" &&
                    answer != "ο" && answer != "οχι" &&
                    answer != "όχι")
                {
                    Console.WriteLine("Please enter Y or N.");
                }

            } while (answer != "y" && answer != "yes" &&
                     answer != "n" && answer != "no" &&
                     answer != "ν" && answer != "ναι" &&
                     answer != "ο" && answer != "οχι" &&
                     answer != "όχι");

            // Determines whether the program will repeat.
            // Καθορίζει αν το πρόγραμμα θα επαναληφθεί.
            repeat = answer == "y" || answer == "yes" ||
                     answer == "ν" || answer == "ναι";

        } while (repeat);

        Console.WriteLine("\nProgram terminated. Goodbye!");
    }
}
