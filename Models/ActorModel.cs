using System;
using System.ComponentModel.DataAnnotations;

namespace eTicket_Project.Models
{
	public class ActorModel
	{
		[Key]
	    public int ActorId { get; set; }

		public string ProfilepicURL { get; set; }

		public string FullName { get; set; }

		public string Bio { get; set; }

	}
}

