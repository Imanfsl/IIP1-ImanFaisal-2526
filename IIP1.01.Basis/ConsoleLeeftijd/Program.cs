/*
 * Auteur: Iman Faisal
 * Datum: 2025-10-01
 */
using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Zorg dat speciale tekens goed getoond kunnen worden
        Console.OutputEncoding = Encoding.UTF8;

        // Vraag de voornaam
        Console.Write("Wat is je voornaam? ");
        string voornaam = Console.ReadLine();

        // Vraag de leeftijd (geheel getal)
        Console.Write("Hoe oud ben je? ");
        int leeftijd = Convert.ToInt32(Console.ReadLine());

        // Vraag één favoriete letter (gebruik de eerste char van de regel)
        Console.Write("Geef je lievelingsletter: ");
        string letterInput = Console.ReadLine();
        char lievelingsLetter = (letterInput != null && letterInput.Length > 0) ? letterInput[0] : ' ';

        Console.WriteLine(); // lege regel

        // Resultaat tonen
        Console.WriteLine($"Hallo {voornaam}! Jij bent {leeftijd} jaar.");
        Console.WriteLine($"Volgend jaar ben je {leeftijd + 1}.");
        Console.WriteLine($"Jouw lievelingsletter is: {lievelingsLetter}");

        // Wacht op een toets voordat het venster sluit
        Console.WriteLine();
        Console.WriteLine("Druk op een toets om af te sluiten...");
        Console.ReadKey(true);
    }
}
