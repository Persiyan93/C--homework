using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Date
{
    public class DateModifier
    {
		private double difference;

		public double Difference
		{
			get { return difference; }
			set { difference = value; }
		}

		public void CalculateDifference(string firstday, string secondday)
		{
			int[] firstDate = firstday.Split(" ").Select(int.Parse).ToArray();
			int[]  secondDate = secondday.Split(" ").Select(int.Parse).ToArray();
			DateTime date1 = new DateTime(firstDate[0], firstDate[1], firstDate[2]);
			DateTime date2 = new DateTime(secondDate[0],secondDate[1],secondDate[2]);
			this.Difference = Math.Abs((date1 - date2).TotalDays);
			
		}




	}
  

}

