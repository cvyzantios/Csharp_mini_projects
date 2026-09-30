using System;

namespace ComparingLoops
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1. Ρωτάμε τον χρήστη πόσα social media θέλει να καταχωρίσει
      Console.Write("Πόσα social media θέλεις να καταχωρίσεις; ");
      int count = Convert.ToInt32(Console.ReadLine());

      // 2. Δημιουργούμε τον πίνακα με το μέγεθος που έδωσε ο χρήστης
      string[] websites = new string[count];

      // 3. Χρησιμοποιούμε for loop για να διαβάσουμε κάθε στοιχείο από το πληκτρολόγιο
      for (int i = 0; i < websites.Length; i++)
      {
        Console.Write($"Δώσε το social medium #{i + 1}: ");
        websites[i] = Console.ReadLine(); // Αποθηκεύουμε την εισαγωγή στον πίνακα
      }

      Console.WriteLine("\n--- Τα social media που καταχώρισες ---");

      // 4. Εμφανίζουμε τα στοιχεία με foreach
      foreach (string website in websites)
      {
        Console.WriteLine(website);
      }
    }
  }
}