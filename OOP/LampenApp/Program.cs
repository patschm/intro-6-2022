namespace LampenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lamp l1 = new Lamp { kleur = ConsoleColor.Yellow, Intensiteit = 200 };
            l1.Aan();
            Console.WriteLine("En toen was er licht");
            l1.Change(ConsoleColor.Red);
            Console.WriteLine("Halloooooo!!");
            l1.Uit();

            Console.WriteLine(l1.Verbruik);

            TL lamp3 = new TL { kleur = ConsoleColor.Cyan, Intensiteit = 200, StartTijd = 800 };
            lamp3.Aan();

            lamp3.Uit();
        }
    }
}