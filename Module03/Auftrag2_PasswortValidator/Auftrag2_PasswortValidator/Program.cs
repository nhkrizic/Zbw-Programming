// TODO 1: string passwort; bool gueltig;
//         do { ... } while (!gueltig);

// TODO 2: In der Schleife Passwort einlesen (Console.ReadLine() ?? "")

// TODO 3: bool hatZiffer = false;
//         foreach (char zeichen in passwort) → char.IsDigit(zeichen) prüfen

// TODO 4: gueltig berechnen und konkrete Fehlermeldung ausgeben

// TODO 5: Nach der Schleife Erfolgsmeldung 

Console.WriteLine("==== Passwort-Validator ====");
string passwort;
bool gueltig;

do
{
    Console.WriteLine("Passwort eingeben: ");
    passwort = Console.ReadLine() ?? "";

    bool hatZahl = false;
    foreach (char zeichen in passwort)
    {
        if (char.IsDigit(zeichen))
        {
            hatZahl = true;
            break;
        }
    }

    gueltig = passwort.Length >= 8 && hatZahl;

    if (!gueltig)
    {
        Console.WriteLine("Passwort ungültig!");
        if (passwort.Length < 8)
        {
            Console.WriteLine("Das Passwort muss mindestens 8 Zeichen lang sein.");
        }
        if (!hatZahl)
        {
            Console.WriteLine("Das Passwort muss mindestens eine Zahl enthalten.");
        }
    }
    
}
while (!gueltig);
Console.WriteLine("Passwort is gültig!");
