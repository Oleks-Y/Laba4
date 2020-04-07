using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_4_1_core_
{
    public interface IShip
    {
        int Speed { get;  }
        int Draught { get;  }
        string Name { get;  }
        string Message();

        void GetMessage(IShip ship);
        

        
    }
}
