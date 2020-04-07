using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba_4_1_core_.Ships
{
    public class Liner : CivilShip
    {
        private int places;
        public int Places { get => places; protected set { places = value > 0 ? value : 0; } }
        public Liner(string name, int storage, int places) : base(name,storage)
        {
            this.places = places;
            speed = 10;
        }

        public override void BeginVoyage(int route)
        {
            Console.WriteLine("We have a trip on our big liner!");
            Thread.Sleep(route / speed * 1000);
            Console.WriteLine("End!");
        }

        public override string ToString()
        {
            return $"Liner {Name} ";
        }
    }
}
