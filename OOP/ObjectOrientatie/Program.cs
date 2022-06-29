namespace ObjectOrientatie
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            // Virtual World
            // Big bang
            Pen p = new Pen();
            //p.lijndikte = 10;
            //p.kleur = ConsoleColor.Red;
            p.Schrijf("Hallo");

            Pen p2 = new Pen(20, ConsoleColor.Red);
          //  p2.lijndikte = 20;
           // p2.kleur = ConsoleColor.DarkMagenta;
            p2.Schrijf("World");

            Pen p3 = new Pen { lijndikte = 30, kleur = ConsoleColor.Yellow };
            p3.Schrijf("Aha!!");



            // Big crunch
        }
    }
}