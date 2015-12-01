using System;
using System.ComponentModel.DataAnnotations;

namespace Lab12.MiniApp.Models
{
    public class UrlModel
    {
        [Url]
        [DataType(DataType.Url)]
        [Required]
        [Display(Name = "Your long url")]
        public String LongUrl { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Give a name to url")]
        public String Name { get; set; }
    }
}