using DAW.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;

namespace DAW.Domain.Models
{
    public class Booking : BaseEntity
    {
        public List<int> RoomsID { get; set; }
        public int CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MyProperty { get; set; }
        public float TotalPrice { get; set; }
        public int PersonCount { get; set; }
        public string Status { get; set; }
    }
}