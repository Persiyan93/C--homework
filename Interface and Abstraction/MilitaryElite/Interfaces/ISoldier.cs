using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ISoldier
    {
        public string Id { get;  }
        public string FirstName { get;  }
        public string  LastName { get;  }
    }
}
