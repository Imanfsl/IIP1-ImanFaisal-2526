/*
 * Auteur: Iman Faisal
 * Datum: 2025-09-25
 */
 using System;

class Program
{
    static void Main()
    {
        // Bestelgegevens inlezen
        Console.WriteLine(" Bestelgegevens");
        
        Console.Write("- naam klant: ");
        string naam = Console.ReadLine();
        
        Console.Write("- aantal toegangsbeurten: ");
        int aantalBeurten = int.Parse(Console.ReadLine());
        
        Console.Write("- prijs (b.v. 122,5): ");
        decimal prijs = decimal.Parse(Console.ReadLine());
        
        Console.Write("- badkledij inbegrepen (typ true of false): ");
        bool badkledijInbegrepen = bool.Parse(Console.ReadLine());
        
        Console.Write("- geslacht (druk 'm' of 'v'): ");
        char geslacht = Console.ReadKey().KeyChar;
        Console.WriteLine(); // nieuwe regel na ReadKey()
        
        // Random kaartnummer genereren (XXX-XXXX-XX formaat)
        Random random = new Random();
        string kaartnummer = $"{random.Next(100, 1000)}-{random.Next(1000, 10000)}-{random.Next(10, 100)}";
        
        Console.WriteLine("\n---");
        
        // Samenvatting met één multiline string interpolatie
        string samenvatting = $@"
 Samenvatting
- houder: {naam}
- geslacht: {geslacht}
- prijs: €{prijs}
- aantal beurten: {aantalBeurten}
- incl. badkledij: {badkledijInbegrepen}
- kaartnummer: {kaartnummer}

druk op een toets om verder te gaan...";
        
        Console.WriteLine(samenvatting);
        Console.ReadKey();
    }
}
