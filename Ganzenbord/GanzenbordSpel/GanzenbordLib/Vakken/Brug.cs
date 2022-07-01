namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Brug.
    /// Ga verder naar 12.
    /// <see href="https://nl.wikipedia.org/wiki/Ganzenbord"/>
    /// </summary>
    public class Brug: Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op de brug ({Positie}) en gaat naar vak 12");
            Vak v12 = Bord.FindVak(12);
            p.Verplaats(v12);
        }
    }
}
