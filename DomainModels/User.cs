using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
	public class User : Common
	{
		[Required]
		public string Firstname { get; set; }
		[Required]
		public string Lastname { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Phone { get; set; }
		[Required]
		public string Email { get; set; }
		public string Gender { get; set; }
		public bool PlayOnline { get; set; }
		public bool PlayOnLocation { get; set; }
		public bool Status { get; set; } //Looking for team
		public string ImageURL { get; set; } //Maybe Base64 

		// Adress Specific
		public string Password { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string Street { get; set; }
		public string Number { get; set; }
		public Team Team { get; set; }
		public int TeamID { get; set; }
		public Organisation Organisation { get; set; }
		public int OrganisationID { get; set; }

		// CSGO Specific
		public int FaceitRating { get; set; }
		public string FaceitURL { get; set; }
		public string SteamURL { get; set; }
		public string Description { get; set; }
		public DateTime Birthday { get; set;}
		//public List<string> PreviousExperience { get; set; }
		//public List<string> Role { get; set; }
	}
}
