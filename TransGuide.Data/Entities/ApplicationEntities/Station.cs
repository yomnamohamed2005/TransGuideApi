using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransGuide.Data.Entities.ApplicationEtities
{
	public  class Station 
	{
		public int Id { get; set; }
		public string Name { get; set; }

        public  decimal Latidude  { get; set; }

        public  decimal  Longitude { get; set; }

		public ICollection<Route> Routes { get; set; } = new HashSet<Route>();
    }
}
