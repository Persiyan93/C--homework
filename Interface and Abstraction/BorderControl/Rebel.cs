using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel:IBuyer
    {
        public Rebel(string name,string age,string group)
        {
            this.Name = name;
            this.Age = int.Parse(age);
            this.Group = group;
        }
        private int food;
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get => this.food; set => this.food=value; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
