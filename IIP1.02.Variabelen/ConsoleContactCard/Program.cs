/*
 * Auteur: Iman Faisal
 * Datum: 2025-09-25
 */
 using System;

class Program
{
    static void Main()
    {
        // Declaratie van variabelen met passende types
        string naam = "Bobby Peru";
        bool isGehuwd = false;
        string telefoon = "0486/33.22.19";
        int leeftijd = 25;
        decimal salaris = 2500.00m;
        char geslacht = 'm';
        double lengte = 1.75;

        // Multiline string met string interpolatie
        string contactKaart = $@"
************************************
* Naam: {naam}
* Gehuwd: {(isGehuwd ? "ja" : "nee")}
* Telefoon: {telefoon}
* Leeftijd: {leeftijd} jaar
* Salaris: {salaris:C}
* Geslacht: {geslacht}
* Lengte: {lengte:F2}m
************************************

druk op een toets om verder te gaan...";

        Console.WriteLine(contactKaart);
        Console.ReadKey();
    }
}
