using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampenApp
{
    internal class TL: Lamp
    {
        private int startTijd = 400;

        public int StartTijd
        {
            get { return startTijd; }
            set {
                if (value > 0)
                {
                    startTijd = value;
                }
            }
        }
        public override void Aan()
        {
            for(int i = 0; i < StartTijd/200; i++)
            {
                Console.BackgroundColor = kleur;
                Console.WriteLine("knipper");
                Task.Delay(200).Wait();
                Console.ResetColor();
            }
            Console.Clear();
            base.Aan();
        }
    }
}
