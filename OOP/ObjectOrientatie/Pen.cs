using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Achternaam van jouw types. Om naam collisions te voorkomen.
// De volledige naam  an Pen is in dit geval ObjectOrientatie.Pen.
// Om teveel typwerkt te vermijden, zal men bij gebruik bovenaan
// using ObjectOrientatie; specificeren.
namespace ObjectOrientatie
{
    // Blauwdruk van een object. 
    // Eveneens een custom type definitie.
    class Pen
    {
        // Fields. Hierin slaan wij eigenschappen op.
        private int _lijndikte;
        // private ConsoleColor kleur;
        // protected. Nog altijd private voor de boze buitenwereld, maar public 
        // voor afgeleide classen.
        protected bool kanSchrijven = true;

        // Properties. Properties gebruik je om
        // Encapsulation te realiseren (Gecontroleerd toegang tot de private fields).
        // Je checkt de inkomende waarde voordat je hem toekent aan het field.
        // Shortcuts: prop of propfull
        public int Lijndikte
        {
            get
            {
                return _lijndikte;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _lijndikte = value;
                }
            }
        }

        // Auto-generating Property. Brengt zijn eigen private field mee.
        public ConsoleColor Kleur { get; set; }

        // Method. Hierin definieren wij het gedrag van een object.
        // Met virtual geef ik aan dat dit gedrag polymorf-ready.
        // Polymorfissme is generaliseren met behoud van specifiek gedrag.
        public virtual void Schrijf(string text)
        {
            Console.ForegroundColor = Kleur;
            Console.WriteLine($"{text} met lijndikte {Lijndikte}");
            Console.ResetColor();
        }

        // Constructor. Bedoeld om fields van een initiele waarde te voorzien.
        // Je kunt meerdere constructors (zelfde naam) opnemen, mits de 
        // argument verschillend zijn.
        // Constructor met altijd de naam van de class zijn en retourneert niks.
        // Definieer alleen constructors als wilt dat bepaalde fields van buitenaf
        // een waarde moeten!!!!! krijgen.
        // Indien dat het geval is, moet je ook geen default constructor meer opnemen.
        public Pen()
        {
            Lijndikte = 10;
            Kleur = ConsoleColor.Blue;
        }
        public Pen(int lineWidth, ConsoleColor color)
        {
            // this? Dat ben ik! Mijn LijnDikte
            this.Lijndikte = lineWidth;
            Kleur = color;
        }
    }
}
