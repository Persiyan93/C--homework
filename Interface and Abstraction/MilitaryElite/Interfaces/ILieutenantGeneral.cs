using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ILieutenantGeneral
    {
        public  HashSet<Private> Privates { get;  }
    }
}
