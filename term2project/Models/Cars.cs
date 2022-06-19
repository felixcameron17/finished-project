using System.ComponentModel.DataAnnotations;

namespace term2project.Models
{
    public class Cars
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Car Name is Required")]
        [Display(Name = "Car Name")]
        public string Name { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [Display(Name = "Deposit Amount")]
        public int DepositAmount​ { get; set; }
        [Display(Name = "Is it automatic? (Check the box for automatic)")]
        public bool IsAuto { get; set; }
        [Display(Name = "Image Link")]
        public string ImageLink { get; set; }
    }

    public class Categories
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "CategoryName")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "CategoryIcon")]
        public string Icon { get; set; }



    }
}

