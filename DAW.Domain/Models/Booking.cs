using DAW.Domain.Models.BaseModels;
using System;

namespace DAW.Domain.Models
{
    public class Booking : BaseEntity
    {
        public int CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MyProperty { get; set; }
        public float TotalPrice { get; set; }
        public int PersonCount { get; set; }
        public string Status { get; set; }
    }
}