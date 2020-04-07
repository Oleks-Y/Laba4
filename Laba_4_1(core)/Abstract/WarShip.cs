using Laba_4_1_core_.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_4_1_core_
{


    public abstract class WarShip : IShip
    {
        protected int speed;
        protected int draught;
        protected int battleNumber;


        public Ranks Rank { get; protected set; }
        public int Draught { get => draught; }
        public string Name { get; set; }
        public int Speed { get => speed; protected set => speed = value > 0 ? value : 0; }
        public int BattleNumber { get => battleNumber; protected set { battleNumber = value > 0 ? value : 0; } }

        public abstract int  FreeWearponSlots{ get; set; }
        public List<Wearpon> Wearpons { get; set;} // in set add calculating of speed 
        public WarShip(string name, Ranks rank, int battleNumber)
        {
            Name = name;
            Rank = rank;
            this.battleNumber = battleNumber;
            Wearpons = new List<Wearpon>();
        }
               
        private void NextRank()
        {
            Rank += 1;
        }
        public abstract void NewBattle();
        public  void AddWearpon(params Wearpon[] w)
        {
            foreach (var a in w)
            {
                if (FreeWearponSlots < 0)
                {
                    Console.WriteLine(this.ToString()+ "is full");
                    return;
                }
                Wearpons.Add(a);
                FreeWearponSlots--;
                Speed -= ((int)a) / 15;
                Console.WriteLine(this.Name+"have new wearpon ");
            }
        }
        public abstract override string ToString();

        public  string Message()
        {
            return this.ToString() + "is here !";
        }

        public  void GetMessage(IShip ship)
        {
            Console.WriteLine(this.ToString() + "get message : " + ship.Message());
        }


    }
}
