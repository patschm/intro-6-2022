namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Einde.
    /// Wie hier als eerste komt heeft gewonnen.
    /// <see href="https://nl.wikipedia.org/wiki/Ganzenbord"/>
    /// </summary>
    public class Einde : Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op Einde ({Positie}) en is de winnaar");
            p.IsWinnaar = true;
        }
    }
}
