namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Gevangenis.
    /// Wie hier komt moet er blijven tot een andere speler er komt. 
    /// Degene die er het eerst was speelt dan verder.
    /// <see href="https://nl.wikipedia.org/wiki/Ganzenbord"/>
    /// </summary>
    public class Gevangenis : Vak
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
            Console.WriteLine($"{p.Naam} landt in de Gevangenis ({Positie}) en moet wachten tot er iemand anders komt.");
            p.KanNietGooien = true;
            gevangen = p;
        }
    }
}
