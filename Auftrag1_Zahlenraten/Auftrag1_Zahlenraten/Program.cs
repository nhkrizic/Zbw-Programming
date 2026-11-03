// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================
// TODO 1: Random-Objekt erstellen, Zufallszahl 1-100 generieren
//         var random = new Random();
//         int geheimzahl = random.Next(1, 101);

var random = new Random();
int geheimzahl = random.Next(1, 101);

// TODO 2: Variablen für Versuchszähler und geraten-Flag

int versuche = 0;



// TODO 3: while-Schleife (!geraten)
//         - Eingabe lesen
//         - int.TryParse prüfen
//         - Hinweis ausgeben (zu klein / zu gross / richtig)
//         - Versuchszähler erhöhen
while (true)
{
    Console.Write("Bitte eine Zahl zwischen 1 und 100 eingeben: ");
    string eingabe = Console.ReadLine();
    int zahl; 
    if (int.TryParse(eingabe, out zahl))
    {
        versuche++;
        if (zahl < geheimzahl)
        {
            Console.WriteLine("Zu klein!");
        }
        else if (zahl > geheimzahl)
        {
            Console.WriteLine("Zu groß!");
        }
        else
        {
            zahl = geheimzahl;
            Console.WriteLine($"Richtig! Die Zahl war {geheimzahl}. Du hast {versuche} Versuche benötigt.");

        }
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.");
    }
    }

// TODO 4: Glückwunsch mit Anzahl Versuche ausgeben