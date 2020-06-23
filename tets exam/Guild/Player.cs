using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Guild
{
    public class Player
    {
		public Player(string name,string class1)
		{
			this.Name = name;
			this.Class = class1;
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string class1;

		public string Class
		{
			get { return class1; }
			set { class1 = value; }
		}
		private string rank="Trial";

		public string Rank
		{
			get { return rank; }
			set { rank = value; }
		}
		private string description="n/a";

		public string Description
		{
			get { return description; }
			set { description = value; }
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			
			sb.AppendLine($"Player {Name}: {Class}");
			
			sb.AppendLine($"Rank: {Rank}");
			sb.AppendLine($"Description: {Description}");
			return sb.ToString().Trim();

		
		}



	}
}
