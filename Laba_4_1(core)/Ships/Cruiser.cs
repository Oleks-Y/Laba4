using Laba_4_1_core_.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_4_1_core_.Ships
{
    public class Cruiser : WarShip
    {
        private int freeWearponSlots = 7;
        public Cruiser(string name, Ranks rank, int battlenumber) : base(name, rank, battlenumber)
        {
            Speed = 20;
            draught = 60;
        }

        public override int FreeWearponSlots { get => freeWearponSlots; set => freeWearponSlots = value > 0 ? value : 0; }

        public override void NewBattle()
        {
            BattleNumber += 1;
            if (battleNumber > 5) Rank = Ranks.Third;
            else if (battleNumber > 10) Rank = Ranks.Second;
            else if (battleNumber > 20) Rank = Ranks.First;
        }
        public void GetCommand(Battleship battleship)
        {
            var command = battleship.Command();
            switch (command)
            {
                case "Command 1": Console.WriteLine(this.ToString() + "doing Action 1 !"); break;
                case "Command 2": Console.WriteLine(this.ToString() + "doing Action 2 !"); break;
                case "Command 3": Console.WriteLine(this.ToString() + "doing Action 3 !"); break;
                default: Console.WriteLine(this.ToString() + "doing Action 4 !"); break;

            }
        }
        public override string ToString()
        {
            return $" Cruiser {Name} Rank : {Rank}; Number of battles {BattleNumber}";
        }
    }
}
