namespace ObjectOrientatie
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            // Virtual World
            // Big bang
            Pen p = new Pen();
            p.Lijndikte = -100;
            //p.kleur = ConsoleColor.Red;
            p.Schrijf("Hallo");

            Pen p2 = new Pen(-20, ConsoleColor.Red);
          //  p2.lijndikte = 20;
           // p2.kleur = ConsoleColor.DarkMagenta;
            p2.Schrijf("World");

            Pen p3 = new Pen { Lijndikte = 2_000_000_000, Kleur = ConsoleColor.Yellow };
            p3.Schrijf("Aha!!");

            // Generaliseren.
            Pen p4 = new Vulpen { Kleur = ConsoleColor.Red , Lijndikte = 15, SchrijfCount = 15};
            for (int i = 0; i < 5; i++)
            {
                p4.Schrijf("hallo " + i);
                if (i == 10)
                {
                    //p4.SchrijfCount = 100;
                }
            }

            TestPen(p4);
            TestPen(p);
            // Big crunch
        }

        static void TestPen(Pen p)
        {
            p.Schrijf("Ik test de pen");
        }
    }
}