﻿namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Herberg.
    /// Een beurt overslaan.
    /// <see href="https://nl.wikipedia.org/wiki/Ganzenbord"/>
    /// </summary>
    public class Herberg : Vak
    {       
        public override void Actie(Pion p)
        {
            if (!p.BeurtOverslaan)
            {
                Console.WriteLine($"{p.Naam} bezoekt de Herberg ({Positie}) en moet 1 beurt overslaan.");
                p.BeurtOverslaan = true;
            }
            else
            {
                Console.WriteLine($"{p.Naam} verlaat de Herberg ({Positie}) en doet de volgende ronde weer mee");
                p.BeurtOverslaan = false;
            }
        }
    }
}
