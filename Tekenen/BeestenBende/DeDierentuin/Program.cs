using DierenLib;
using DierenLib.Dieren;
using DierenLib.Verblijven;

namespace DeDierentuin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Knutsel de dierentuin in elkaar.
            Dierentuin zoo = new Dierentuin();
            Steppe steppe = new Steppe();
            zoo.VoegToe(steppe);
            Kooi kooi = new Kooi();
            zoo.VoegToe(kooi);
            Aquarium aquarium = new Aquarium();
            zoo.VoegToe(aquarium);

            // Nu gaan we op safari
            steppe.SluitOp(new Zebra());
            steppe.SluitOp(new Wildebeest());
            steppe.SluitOp(new ClownsVis());

            kooi.SluitOp(new Tijger());
            kooi.SluitOp(new Leeuw());

            aquarium.SluitOp(new ClownsVis());
            aquarium.SluitOp(new Sidderaal());
            aquarium.SluitOp(new Leeuw());

            // En nu kunnen we open gaan

            zoo.Open();

        }

        
    }
}