using Laba_4_1_core_.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_4_1_core_.Ships
{
    public class Carrier : WarShip
    {
        private int freeWearponSlots = 10;
        private int numberOfPlanes;

        public Carrier(string name, Ranks rank, int battlenumber, int planes) : base(name, rank, battlenumber)
        {
            numberOfPlanes = planes;
            Speed = 5;
            draught = 300;
        }

        public override int FreeWearponSlots { get => freeWearponSlots; set => freeWearponSlots = value > 0 ? value : 0; }
        public void GetCommand(Battleship battleship)
        {
            var command = battleship.Command();
            switch (command)
            {
                case "Command 1": Console.WriteLine(this.ToString()+" doing Action 1 !");break;
                case "Command 2": Console.WriteLine(this.ToString() + " doing Action 2 !"); break;
                case "Command 3": Console.WriteLine(this.ToString() + " doing Action 3 !"); break;
                default : Console.WriteLine(this.ToString() + " doing Action 4 !"); break;

            }
        }
        public override void NewBattle()
        {
            BattleNumber += 1;
            if (battleNumber > 2) Rank = Ranks.Third;
            else if (battleNumber > 5) Rank = Ranks.Second;
            else if (battleNumber > 10) Rank = Ranks.First;
        }

        public override string ToString()
        {
            return $" Carrier {Name} Rank : {Rank}; Number of battles {BattleNumber}";
        }
    }
}
