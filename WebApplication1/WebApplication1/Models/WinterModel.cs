using System.ComponentModel.DataAnnotations;

namespace Lab2.Web.Models
{
    public class WinterModel
    {
        [Range(-50, 40)]
        public int Temperature { get; set; }

        [Display(Name = "Snow Quantity")]
        [Range(0, 1000)]
        public int SnowQty { get; set; }

        [DataType(DataType.MultilineText)]
        public string Label { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress]
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Snowy Email cool Address")]
        public string FrostyEmailAddress { get; set; }
    }
}