using System;

class MinMaxi
{
    static void Main()
    {
        char answer;

        do
        {
            
            int min = int.MaxValue;

        /* Αρχικοποιούμε το min στη μέγιστη δυνατή τιμή και το max στην ελάχιστη
          ώστε ο πρώτος αριθμός που θα δοθεί να γίνει αυτόματα το νέο min κ
            int min = int.MaxValue; */
            
  /*Δημιουργούμε μια μεταβλητή int με όνομα min.
         Της δίνουμε αρχικά την μεγαλύτερη δυνατή τιμή που μπορεί να πάρει ένα int.
         Δηλαδή:2,147,483,647 */
            int max = int.MinValue;
           
/*
Δημιουργούμε μια μεταβλητή τύπου bool.
Η bool μπορεί να έχει μόνο δύο τιμές:
true
false Εδώ ξεκινάμε με:
hasNumbers = false;
που σημαίνει:
«Μέχρι στιγμής δεν έχει δοθεί κανένας αριθμός.»
Αργότερα, όταν ο χρήστης δώσει τουλάχιστον έναν αριθμό, πιθανότατα θα γίνει:
hasNumbers = true;
Αυτή η μεταβλητή λοιπόν λειτουργεί σαν σημαία (flag) που μας πληροφορεί αν έχουμε πάρει αριθμούς από τον χρήστη.
*/
            bool hasNumbers = false;

            Console.WriteLine("Εισάγετε αριθμούς. Πληκτρολογήστε 'q' για να σταματήσετε.");

            while (true)
            {
                Console.Write("Δώστε αριθμό: ");
                string input = Console.ReadLine();

                // Έλεγχος αν ο χρήστης θέλει να σταματήσει
                if (input.ToLower() == "q")
                {
                    break;
                }

                // Προσπάθεια μετατροπής του κειμένου σε αριθμό
                if (int.TryParse(input, out int currentNumber))
                {
                    hasNumbers = true;

                    // Έλεγχος για ελάχιστο και μέγιστο
                    if (currentNumber < min)
                        min = currentNumber;

                    if (currentNumber > max)
                        max = currentNumber;
                }
                else
                {
                    Console.WriteLine("Μη έγκυρη είσοδος! Παρακαλώ δώστε αριθμό ή 'q'.");
                }
            }

            // Εμφάνιση αποτελεσμάτων
            if (hasNumbers)
            {
                Console.WriteLine("\nMin ειναι  max: " + min + " " + max);
            }
            else
            {
                Console.WriteLine("\nΔεν δώσατε κανέναν αριθμό.");
            }

            // Ερώτηση για επανάληψη
            Console.Write("\n Παμε απο την αρχη? (Y/N): ");
            answer = Convert.ToChar(Console.ReadLine().ToUpper());

        } while (answer == 'Y');

        Console.WriteLine("\nΤελος προγραμματος.");
    }
}