using System;
using System.ComponentModel.DataAnnotations;

namespace eTicket_Project.Models
{
	public class ProducerModel
	{
        [Key]
        public int ProducerId { get; set; }

        public string ProfilepicURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }
    }
}

