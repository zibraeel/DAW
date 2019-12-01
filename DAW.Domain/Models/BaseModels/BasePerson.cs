namespace DAW.Domain.Models.BaseModels
{
    public class BasePerson : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
