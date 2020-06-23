using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class Pokemon
    {
		public Pokemon(string pokemonName,string pokemonElement,double pokemoHealth)
		{
			this.Name = pokemonName;
			this.Element = pokemonElement;
			this.Health = pokemoHealth;
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string element;

		public string Element
		{
			get { return element; }
			set { element = value; }
		}
		private double health;

		public double Health
		{
			get { return health; }
			set { health = value; }
		}



	}
}
