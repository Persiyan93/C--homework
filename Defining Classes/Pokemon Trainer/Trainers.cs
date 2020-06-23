using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class Trainer
    {
		public Trainer(string name)
		{
			this.Name = name;
		}
		private	string	 name;

		public  string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int numberfbadge;

		public int NumberOfBadge
		{
			get { return  numberfbadge; }
			set {  numberfbadge = value; }
		}
		private List<Pokemon> colection = new List<Pokemon>();

		public List<Pokemon> Colection 
		{
			get { return colection ; }
			set { colection =  value; }
		}



	}
}
