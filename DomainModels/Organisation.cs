using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
	public class Organisation : Common
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public List<Team> Teams { get; set; }
		public User Owner { get; set; }
		public int OwnerID { get; set; }

	}
}
