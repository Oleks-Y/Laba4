using Laba_4_1_core_.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_4_1_core_.Ships
{
    public class Battleship : WarShip
    {
        private int freeWearponSlots = 10;
        public Battleship(string name, Ranks rank, int battlenumber) : base(name, rank, battlenumber)
        {
            Speed = 10;
            draught = 100;
            

        }

        public override int FreeWearponSlots { get => freeWearponSlots; set => freeWearponSlots= value > 0 ?  value : 0; }

        

        public override void NewBattle()
        {
            BattleNumber += 1;
            if (battleNumber > 5) Rank = Ranks.Third;
            else if (battleNumber > 10) Rank = Ranks.Second;
            else if (battleNumber > 20) Rank = Ranks.First;
        }

        public string Command()
        {
            var rnd = new Random();
            switch (rnd.Next(1,4))
            {
                case 1: return "Command 1"; 
                case 2: return "Command 2"; 
                case 3: return "Command 3"; 
                default: return "Command 4"; 
                         
            }
        }

        public override string ToString()
        {
            return $" Battleship {Name} Rank : {Rank}; Number of battles {BattleNumber}";
        }

        
    }
}
