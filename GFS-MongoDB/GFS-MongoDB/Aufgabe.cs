using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GFS_MongoDB
{
    internal class Aufgaben
    {
        public static Aufgabe[] Aufgabens =
        {
            new Aufgabe()
            { // use appdb
                Description = "Wechsel zur Datenbank mit dem Namen 'appdb'.",
                WantedSolutionInput = "Gib den Befehl an den du benutzt hast um die Datenbank zu erstellen.",
                Solutions = new[] { "useappdb", "use" },
                Hint = "Verwende den Befehl 'use'."
            },
            new Aufgabe()
            { // db.users.countDocuments()
                Description = "Gib in der Collection 'users' die Anzahl der user an.",
                WantedSolutionInput = "Die Anzahl der user in der Collection 'users'.",
                Solutions = new[] { "10000" },
                Hint = "Verwende den Befehl 'countDocuments()'."
            },
            new Aufgabe()
            { // db.users.countDocuments({name:"Müller"})
                Description = "Filtere nach: Nachnamen Müller.",
                WantedSolutionInput = "Die Anzahl der user.",
                Solutions = new[] { "23" },
                Hint = "Als Parameter ein Objekt mit dem Namen 'name' und dem Wert 'Müller' an."
            },
            new Aufgabe()
            { // db.users.countDocuments({name:"Müller", freunde: {$size: 5}})
                Description = "Filtere nach: Nachnamen Müller und 5 Freunde.",
                WantedSolutionInput = "Die Anzahl der user.",
                Solutions = new[] { "4" },
                Hint = "Ein weiterer Parameter ist nötig. Dieser ist ein Objekt mit dem Namen 'freunde' und dem Wert '$size'."
            },
            new Aufgabe()
            { // db.users.find({alter: {$gt: 40}}).sort({name:1, alter:1}).limit(1)
                Description = "Filtere nach: über 40 Jahre, und sortiere nach dem Nachnamen und Alter.",
                WantedSolutionInput = "Die Postleitzahl des ersten user.",
                Solutions = new[] { "47643" },
                Hint = "Verwende die Befehle 'find()', 'sort()' und 'limit()'."
            },
            new Aufgabe()
            { // db.users.countDocuments({$or:[{name: {$in: ["Müller", "Patberg"]}}, {alter:40}]})
                Description = "Filtere nach: Nachnamen Müller oder Patberg oder 40 Jahre alt.",
                WantedSolutionInput = "Die Anzahl der user.",
                Solutions = new[] { "193" },
                Hint = "Verwende den Befehl 'countDocuments()' und den Operator '$or' und '$in'."
            },
            new Aufgabe()
            { // db.users.countDocuments({$expr: {$lt: ["$alter", "$jahre_seit_registrierung"]}})
                Description = "Filtere nach: das Alter weniger als die jahre_seit_registrierung",
                WantedSolutionInput = "Die Anzahl der user.",
                Solutions = new[] { "10" },
                Hint = "'$expr' und '$lt' ist nötig."
            },
            new Aufgabe()
            { // db.users.countDocuments({ telefon: { $exists: true } })
                Description = "Filtere nach: Nutzern die eine Telefonnummer besitzen.",
                WantedSolutionInput = "Die Anzahl der user.",
                Solutions = new[] { "4996" },
                Hint = "'$exists'"
            },
            new Aufgabe()
            { // db.users.find({ "adresse.hausnummer": "420", geschlecht:{$ne: "m"} })
                Description = "Filtere nach: Hausnummer 420 und geschlecht nicht männlich",
                WantedSolutionInput = "Den Nachname des Nutzers.",
                Solutions = new[] { "wagner" },
                Hint = "Im ersten Objektname ist ein '.' und der Wert des 2ten beinhaltet '$ne'"
            }
        };
    }

    internal class Aufgabe
    {
        public static int IDCounter { get; set; }
        public static int UsedHintCounter { get; set; }


        public int ID { get; set; }
        public string Description { get; set; }
        public string WantedSolutionInput { get; set; }
        public string[] Solutions { get; set; }
        public string Hint { get; set; }

        public int Tries { get; set; }

        private bool hintUsed = false;

        public Aufgabe()
        {
            ID = IDCounter++;
        }

        public Aufgabe(string description, string[] solutions, string hint = null)
        {
            ID = IDCounter++;
            Description = description;
            Solutions = solutions;
            Hint = hint;
        }
   
        public bool CheckSolution(string solution)
        {
            Tries++;
            return Solutions.Contains(string.Concat(solution.ToLower().TrimEnd(';').Replace('"', '\'').Where(c => !char.IsWhiteSpace(c))));
        }

        public string GetHint()
        {
            if (!hintUsed)
            {
                UsedHintCounter++;
            }
            hintUsed = true;
            return Hint ?? "Kein Hinweis vorhanden.";
        }
    }
}
