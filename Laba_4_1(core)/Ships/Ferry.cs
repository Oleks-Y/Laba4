using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba_4_1_core_.Ships
{
    class Ferry : CivilShip
    {
        public Ferry(string name, int storage) : base(name, storage)
        {
            speed = 5;
        }
        public override  void BeginVoyage(int route)
        {
            Console.WriteLine("We have a trip on our small ferry!");
            Thread.Sleep(route / speed * 1000);
            Console.WriteLine("End!");
        }

        public override string ToString()
        {
            return $"Ferry {Name} ";
        }
    }
}
