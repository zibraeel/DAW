using DAW.Domain.Models.BaseModels;
using System;

namespace DAW.Domain.Models
{
    public class Customer : BasePerson

    {
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}