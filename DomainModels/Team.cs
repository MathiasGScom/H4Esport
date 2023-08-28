using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
	public class Team : Common
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string TeamImageURL { get; set; }
		public List<User> Players { get; set; }
		public Organisation Organisation { get; set; }
		public int OrganisationID { get; set; }
		public User Coach { get; set; }
		public int CoachID { get; set; }
		public User Owner { get; set; }
		public int OwnerID { get; set; }
		public User[] Starters { get; set; } = new User[5];
		public List<User> Substitutes { get; set;}

	}
}
