using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4_1_core_
{
    public abstract class CivilShip : IShip
    {
        protected int speed;
        protected int draught;
        protected int storage;
        public int Speed { get => speed; private set => speed = value > 0 ? value : 0; }

        public int Draught { get => draught; }

        public string Name { get; set; } 
        public int Storage { get => storage; }

        public CivilShip(string name, int storage)
        {
            Name = name;
            this.storage = storage;
        }
        public string Message()
        {
            return this.ToString() + "is here !";
        }

        public void GetMessage(IShip ship)
        {
            Console.WriteLine(this.ToString() + "get message : " + ship.Message());
        }
        public abstract override string ToString();

        public abstract void BeginVoyage(int route);
        




    }
}
