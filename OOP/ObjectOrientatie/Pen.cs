using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientatie
{
    class Pen
    {
        // Fields. Hierin slaan wij eigenschappen op.
        public int lijndikte;
        public ConsoleColor kleur;

        // Method. Hierin definieren wij het gedrag van een object
        public void Schrijf(string text)
        {
            Console.ForegroundColor = kleur;
            Console.WriteLine($"{text} met lijndikte {lijndikte}");
            Console.ResetColor();
        }

        // Constructor. Bedoeld om fields van een initiele waarde te voorzien
        // Je kunt meerdere constructors (zelfde naam) opnemen, mits de 
        // argument verschillend zijn.
        // Constructor met altijd de naam van de class zijn en retourneert niks.
        // Definieer alleen constructors als wilt dat bepaalde fields van buitenaf
        // een waarde moeten!!!!! krijgen.
        // Indien dat het geval is,moet je ook geen default constructor meer opnemen.
        public Pen()
        {
            lijndikte = 10;
            kleur = ConsoleColor.Blue;
        }
        public Pen(int lineWidth, ConsoleColor color)
        {
            lijndikte = lineWidth;
            kleur = color;
        }
    }
}
