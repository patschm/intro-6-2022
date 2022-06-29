namespace LampenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lamp l1 = new Lamp { kleur = ConsoleColor.Yellow, intensiteit = 200 };
            l1.Aan();
            Console.WriteLine("En toen was er licht");
            l1.Change(ConsoleColor.Red);
            Console.WriteLine("Halloooooo!!");
            l1.Uit();
        }
    }
}