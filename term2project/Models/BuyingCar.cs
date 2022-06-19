using System.ComponentModel.DataAnnotations;

namespace term2project.Models
{
    public class BuyingCar
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        [Display(Name = "Bank Number")]
        public int BankNumber { get; set; }
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
    }
}
