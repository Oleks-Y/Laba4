using System;
using System.Threading.Tasks;
using Laba_4_1_core_.Ships;
using Laba_4_1_core_.Types;

namespace Laba_4_1_core_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Battleship("Yamato", Types.Ranks.First, 23);
            Console.WriteLine(a);

            a.AddWearpon(Wearpon.Cannon, Wearpon.MashineGun, Wearpon.MashineGun);

            var b = new Carrier("Green Day", Types.Ranks.Second, 45,60);
            Console.WriteLine(b);

            b.GetCommand(a);
            var f = new Ferry("Baby", 15);
            f.BeginVoyage(23);

            var c = new Cruiser("Bara", Ranks.Third, 5);
            c.GetMessage(a);
            c.NewBattle();
            Console.WriteLine(c);

            


        }
    }
}
