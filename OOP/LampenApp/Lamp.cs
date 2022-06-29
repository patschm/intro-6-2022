namespace LampenApp
{
    internal class Lamp
    {
        private int intensiteit;
        public ConsoleColor kleur;

        public int Intensiteit
        {
            get
            {
                return intensiteit;
            }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    intensiteit = value;
                }
            }
        }
        // Een berekend property. Hoeft geen eigen field te hebben.
        // get en/of set is optioneel
        public int Verbruik
        {
            get
            {
                return 3600 * Intensiteit;
            }
        }

        public virtual void Aan()
        {
            Console.BackgroundColor = kleur;
            Console.WriteLine($"De lamp brandt met intensiteit {intensiteit} lumen");
        }
        public void Uit()
        {
            Console.ResetColor();
            Console.WriteLine("De lamp is uit");
        }
        public void Change(ConsoleColor color)
        {
            kleur = color;
            Console.BackgroundColor = kleur;
            Console.WriteLine("Ander kleurtje met intensiteit {intensiteit} lumen");
        }
    }
}
