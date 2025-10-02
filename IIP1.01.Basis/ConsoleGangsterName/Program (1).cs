/*
 * Auteur: Iman Faisal
 * Datum: 2025-09-25
 */
using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Zorg dat speciale karakters correct kunnen verschijnen
        Console.OutputEncoding = Encoding.UTF8;

        // Header
        Console.WriteLine("*****************************");
        Console.WriteLine("|  GANGSTA NAME BUILDER  |");
        Console.WriteLine("*****************************");
        Console.WriteLine();

        // Invoer van de gebruiker
        Console.Write("Give the first name of any Disney character: ");
        string firstName = Console.ReadLine();

        Console.Write("Give any workbench tool: ");
        string tool = Console.ReadLine();

        Console.Write("What is your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine();

        // Bouw de gangsta-naam
        string gangstaName = $"{firstName} 'the {tool}' {lastName}";

        // Label + naam (naam in groen)
        Console.Write("Your gangsta name: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(gangstaName);
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(true);
    }
}
