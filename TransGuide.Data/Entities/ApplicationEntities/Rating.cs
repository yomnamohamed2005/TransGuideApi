using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransGuide.Data.Entities.ApplicationEntities
{
	public  class Rating
    {
        public int Id { get; set; }
        public int UserId { get; set; }     
        public int TripId { get; set; }     
        public int Score { get; set; }      
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

