namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Put
    /// Wie hier komt moet er blijven tot een andere speler er komt. 
    /// Degene die er het eerst was speelt dan verder.
    /// <see href="https://nl.wikipedia.org/wiki/Ganzenbord"/>
    /// </summary>
    public class Put : Vak
    {
        private Pion gevangen = null;

        public override void Actie(Pion p)
        {
            if (gevangen != null && gevangen != p)
            {
                Console.WriteLine($"{gevangen.Naam} is nu vrij.");
                gevangen.KanNietGooien = false;
            }
            if (p.KanNietGooien) return;
            Console.WriteLine($"{p.Naam} landt in de Put ({Positie}) en moet wachten tot iemand anders erop komt.");
            p.KanNietGooien = true;
            gevangen = p;
        }
    }
}
