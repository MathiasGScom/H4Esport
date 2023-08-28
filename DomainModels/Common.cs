using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
	public abstract class Common
	{
		public uint ID { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
		
	}
}
