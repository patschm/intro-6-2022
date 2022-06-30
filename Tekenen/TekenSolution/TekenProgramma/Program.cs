using Shapes;

namespace TekenProgramma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            do
            {
                Figuur fig = SelectFiguur();
                canvas.Add(fig);
                canvas.Ververs();
            }
            while (true);
        }

        static Figuur SelectFiguur()
        {
            do
            {
                Console.WriteLine("Welk figuur? (r,d,c)");
                string fig = Console.ReadLine();
                switch (fig.Substring(0, 1).ToLower())
                {
                    case "r":
                        {
                            return CreateRectangle(200, 100);
                        }
                    case "c":
                        {
                            return CreateCircle(200);
                        }
                    case "d":
                        {
                            return CreateTriangle(200, 100, 30);
                        }
                    default:
                        {
                            Console.WriteLine("Ongeldig figuur");
                            break;
                        }
                }
            }
            while (true);
        }
        static Driehoek CreateTriangle(int basis = 200, int hoogte=100, int hoek=30)
        {
            Position pos = RandomPosition();
            return new Driehoek { Positie = pos,Basis=basis, Hoek = hoek, Hoogte = hoogte};
        }
        static Cirkel CreateCircle(int straal = 100)
        {
            Position pos = RandomPosition();
            return new Cirkel { Positie = pos, Straal = straal };
        }
        static Rechthoek CreateRectangle(int hoogte = 100, int breedte = 200)
        {
            Position pos = RandomPosition();
            return new Rechthoek { Positie = pos, Hoogte = hoogte, Breedte = breedte };
        }

        private static Position RandomPosition()
        {
            Random random = new Random();
            return new Position { X = random.Next(1, 10) * 50, Y=random.Next(1, 10)*50 };
        }
    }
}