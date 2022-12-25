using System;
using eTicket_Project.Data;

namespace eTicket_Project.Models
{
	public class MovieModel
	{
		public int MovieID { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public DateTime Startdate { get; set; }

		public DateTime Enddate { get; set; }

		public double price { get; set; }

		public string ImageURL { get; set; }

		public MovieCategory MovieCategory { get; set; }
	}
}

