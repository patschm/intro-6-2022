using GanzenbordLib;

namespace GanzenbordApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bord board = new Bord();
            board.Registreer("Patrick");
            board.Registreer("Peter");
            Console.WriteLine("=============================================");
            board.Start();
            do
            {
                board.Beurt();
                Console.WriteLine("Enter voor next");
                Console.ReadLine();
                board.Next();
            }
            while (!board.IsBeeindigd);
        }
    }
}