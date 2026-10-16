
/*==================================================
       ΣΗΜΕΙΩΣΕΙΣ C#: ΔΙΑΔΡΑΣΤΙΚΟ XOR CIPHER
==================================================

1. ΤΙ ΠΕΤΥΧΑΜΕ:
--------------------------------------------------
- Ο χρήστης δίνει πλέον δυναμικά τόσο το μήνυμα (string) 
  όσο και το κλειδί (int).
- Το πρόγραμμα κρυπτογραφεί και αποκρυπτογραφεί 
  χρησιμοποιώντας τις τιμές που έδωσε ο χρήστης.

2. ΒΑΣΙΚΕΣ ΕΝΤΟΛΕΣ ΠΟΥ ΧΡΗΣΙΜΟΠΟΙΗΣΑΜΕ:
--------------------------------------------------
- string msg = Console.ReadLine();
- int key = Convert.ToInt32(Console.ReadLine());
- for loops & XOR operator (^)
==================================================
*/
using System;

class Encode
{
    static void Main()
    {
        // The original message to be encoded.
        
      Console.Write("Γράψε μια πρόταση: ");
string msg = Console.ReadLine(); // Δέχεται όλη την πρόταση 100%

        // Stores the encoded message.
        // Αποθηκεύει το κωδικοποιημένο μήνυμα.
        string encmsg = "";

        // Stores the decoded message.
        // Αποθηκεύει το αποκωδικοποιημένο μήνυμα.
        string decmsg = "";

        // The key used for encoding and decoding.
        // Το κλειδί που χρησιμοποιείται για κωδικοποίηση
        // και αποκωδικοποίηση
      
        Console.Write("Γράψε  κλειδί: ");
         int key = Convert.ToInt32(Console.ReadLine()); 
        //int key;

        // Display the original message.
        // Εμφανίζουμε το αρχικό μήνυμα.
        Console.Write("Original message: ");
        Console.WriteLine(msg);

        // Encode the message one character at a time.
        // Κωδικοποιούμε το μήνυμα έναν χαρακτήρα κάθε φορά.
        for (int i = 0; i < msg.Length; i++)
        {
            // XOR the character with the key.
            // Εφαρμόζουμε XOR στον χαρακτήρα με το κλειδί.
            encmsg = encmsg + (char)(msg[i] ^ key);
        }

        // Display the encoded message.
        // Εμφανίζουμε το κωδικοποιημένο μήνυμα.
        Console.Write("Encoded message: ");
        Console.WriteLine(encmsg);

        // Decode the encoded message one character at a time.
        // Αποκωδικοποιούμε το μήνυμα έναν χαρακτήρα κάθε φορά.
        for (int i = 0; i < encmsg.Length; i++)
        {
            // Applying XOR with the same key restores the character.
            // Η εφαρμογή XOR με το ίδιο κλειδί επαναφέρει
            // τον αρχικό χαρακτήρα.
            decmsg = decmsg + (char)(encmsg[i] ^ key);
        }

        // Display the decoded message.
        // Εμφανίζουμε το αποκωδικοποιημένο μήνυμα.
        Console.WriteLine("Decoded message:");
        Console.WriteLine(decmsg);
    }
}