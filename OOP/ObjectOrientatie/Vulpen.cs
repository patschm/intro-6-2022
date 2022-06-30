namespace ObjectOrientatie
{
    // Vulpen erft van Pen en daarmee krijgt hij de eigenschappen en gedrag
    // van de pen. Erfen doe je met de ':' (inherits, extends)
    // Je kunt maar van 1 classe tegelijk erfen.
    // sealed betekent dat je van vulpen niet meer kunt erfen.
    internal sealed class Vulpen : Pen
    {
        private int schrijfCount = 10;
        public int SchrijfCount
        {
            get { return schrijfCount; }
            set { schrijfCount = 10; }
        }
        
        // Met override activeer ik het polymorfisme.
        // Dit kan alleen als de base methode virtual (of abstract)
        // Optioneel kan ik hier ook sealed opnemen. Hiermee vernietig ik 
        // het polymorf-ready (virtual) zijn.
        public override void Schrijf(string text)
        {
            // Waar this ikzelf ben, is base mijn directe parent.
           //base.Schrijf(text);
            if (schrijfCount > 0)
            {
                Console.ForegroundColor = Kleur;
                Console.WriteLine($"Vulpen schrijft {text} met lijndikte {Lijndikte}");
                Console.ResetColor();
                schrijfCount--;
            }
            else
            {
                Console.WriteLine("De vulling is op");
            }
        }
    }
}
