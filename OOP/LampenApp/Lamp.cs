namespace LampenApp
{
    internal class Lamp
    {
        public int intensiteit;
        public ConsoleColor kleur;

        public void Aan()
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
