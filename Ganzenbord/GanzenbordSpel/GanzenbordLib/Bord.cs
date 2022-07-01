﻿using GanzenbordLib.Vakken;

namespace GanzenbordLib
{
    public class Bord
    {
        private List<Pion> pionnen = new List<Pion>();
        private Vak[] vakken = new Vak[64];
        private Pion ActievePion;
        public bool IsBeeindigd { get; set; }
        public Dobbelsteen Steen1 = new Dobbelsteen();
        public Dobbelsteen Steen2 = new Dobbelsteen();

        private void Initialize()
        {
            // Initialiseer de vakken
            for(int i = 0; i < vakken.Length; i++)
            {
                vakken[i] = new Vak { Bord = this, Positie = i };
            }
            // Vervang nu de speciale vakken
            vakken[0] = new Start { Bord = this, Positie = 0};
            vakken[5] = new Turbo { Bord = this, Positie = 5 };
            vakken[9] = new Turbo { Bord = this, Positie = 9 };
            vakken[14] = new Turbo { Bord = this, Positie = 14 };
            vakken[18] = new Turbo { Bord = this, Positie = 18 };
            vakken[23] = new Turbo { Bord = this, Positie = 23 };
            vakken[27] = new Turbo { Bord = this, Positie = 27 };
            vakken[32] = new Turbo { Bord = this, Positie = 32 };
            vakken[36] = new Turbo { Bord = this, Positie = 36 };
            vakken[41] = new Turbo { Bord = this, Positie = 41 };
            vakken[45] = new Turbo { Bord = this, Positie = 45 };
            vakken[50] = new Turbo { Bord = this, Positie = 50 };
            vakken[54] = new Turbo { Bord = this, Positie = 54 };
            vakken[59] = new Turbo { Bord = this, Positie = 59 };
            vakken[6] = new Brug { Bord = this, Positie = 6 };
            vakken[19] = new Herberg { Bord = this, Positie = 19 };
            vakken[26] = new Dobbelen { Bord = this, Positie = 26 };
            vakken[31] = new Put { Bord = this, Positie = 31 };
            vakken[42] = new DoornStruik { Bord = this, Positie = 42 };
            vakken[52] = new Gevangenis { Bord = this, Positie = 52 };
            vakken[58] = new Dood { Bord = this, Positie = 58 };
            vakken[63] = new Einde { Bord = this, Positie = 63 };
        }
        public void Beurt()
        {
            if (ActievePion.BeurtOverslaan)
            {
                ActievePion.Verplaats(ActievePion.HuidigVak);
                NextPlayer();
                return;
            }
            Console.WriteLine($"{ActievePion.Naam} is aan de beurt.");
            int nr = WerpStenen();
            Console.WriteLine($"{ActievePion.Naam} gooit een {Steen1.Worp} en {Steen2.Worp}");
            Vak newPos = FindVak(ActievePion.Positie + nr);
            ActievePion.Verplaats(newPos);
            IsBeeindigd = ActievePion.IsWinnaar;
            if (IsBeeindigd) return;
            NextPlayer();
        }
        private void NextPlayer()
        {
            // Bepaal de volgende speler
            int currenPionIndex = 0;
            for (int i = 0; i < pionnen.Count; i++)
            {
                if (ActievePion == pionnen[i])
                {
                    currenPionIndex = i;
                    break;
                }
            }
            if (currenPionIndex + 1 >= pionnen.Count)
            {
                // Laatste pion, begin weer van voorafaan
                ActievePion = pionnen[0];
            }
            else
            {
                ActievePion = pionnen[currenPionIndex + 1];
            }
        }
        public int WerpStenen()
        {
            Steen1.Gooi();
            Steen2.Gooi();
            return Steen1.Worp + Steen2.Worp;
        }
        public void Start()
        {
            ActievePion = pionnen.First();  
        }
        public void Registreer(string spelerNaam)
        {
            Pion p = new Pion();
            p.Naam = spelerNaam;
            p.Verplaats(FindVak(0));
            pionnen.Add(p);
        }
        internal Vak FindVak(int position)
        {
            if (position >= 0 && position < vakken.Length)
            {
                return vakken[position];
            }

            // Teveel gegooid. We moeten het teveel gegooide aantal vakken terug
            if (position >= vakken.Length)
            {
                int vakkenTeveel = position - (vakken.Length - 1); // er zijn 64 vakken. Corrigeer naar 63
                position = (vakken.Length - 1) - vakkenTeveel;
                return vakken[position];
            }
            return null;           
        }
        public Bord()
        {
            Initialize();
        }
    }
}