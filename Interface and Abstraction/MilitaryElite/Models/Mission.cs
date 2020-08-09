using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MilitaryElite.Models
{
    public class Mission
    {
        private string state;
        public string CodenName { get; set; }
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (value!="inProgress"&&value!="Finished")
                {
                    throw new ArgumentException();
                }
                this.state = value;
            }
        }
        public void CompleteMission()
        {
            this.State = "Finished";
        }
    }
}
