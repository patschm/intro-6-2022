namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Turbo.
    /// Op sommige velden staat een gans afgebeeld. 
    /// Het zijn die van de negenvouden en de negenvouden minus vier, dus de hokjes 
    /// 5, 9, 14, 18, 23, 27, 32, 36, 41, 45, 50, 54, 59. 
    /// Wie hierop terechtkomt, moet hetzelfde aantal ogen verder tellen
    /// <see href="https://nl.wikipedia.org/wiki/Ganzenbord"/>
    /// </summary>
    public class Turbo : Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op Turbo ({Positie})");
            // Bepaal wat de speler geworpen heeft.
            // De stenen vind je op het bord
            int worp = Bord.Steen1.Worp + Bord.Steen2.Worp;
            
            // Speciale regel.
            // Wie bij de eerste worp een 5 en een 4 gooit, gaat meteen door naar 53.
            // Wie bij de eerste worp een 6 en een 3 gooit, gaat door naar 26.
            if (p.VorigePositie == 0 && worp == 9)
            {
                // Je hoeft maar een steen te testen. De andere heeft automatisch
                // de andere waard. Als Steen1 = 4, weet je dat Steen2 = 5 en omgekeerd.
                if (Bord.Steen1.Worp == 4 || Bord.Steen1.Worp == 5)
                {
                    Console.WriteLine($"{p.Naam} gaat naar 53");
                    Vak vNext2 = Bord.FindVak(53);
                    p.Verplaats(vNext2);
                }
                if (Bord.Steen1.Worp == 3 || Bord.Steen1.Worp == 6)
                {
                    Console.WriteLine($"{p.Naam} gaat naar 26");
                    Vak vNext2 = Bord.FindVak(26);
                    p.Verplaats(vNext2);
                }
            }
            else
            {
                Console.WriteLine($"{p.Naam} gaat {worp} posities verder");
                Vak vNext = Bord.FindVak(Positie + worp);
                p.Verplaats(vNext);
            }
        }
    }
}
