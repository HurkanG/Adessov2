using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class TravelPlan
	{

        [Key]
        public int TravelId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime TravelDate { get; set; }
        public string Description { get; set; }
        public int SeatNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

