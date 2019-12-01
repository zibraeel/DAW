using DAW.Domain.Models.BaseModels;
using System;

namespace DAW.Domain.Models
{
    public class Employee : BasePerson
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string JobTitle { get; set; }
        public Employee SuperiorId { get; set; }
    }
}
