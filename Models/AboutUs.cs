using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XtendersProject.Models
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "About Us Heading")]
        [Required]
        public string AboutUsHeading { get; set; }
        [Display(Name = "About Us Text")]
        [Required]
        public string AboutUsText { get; set; }
        [Display(Name = "Why Us Heading")]
        [Required]
        public string WhyUsHeading { get; set; }
        [Display(Name = "Why Us Text")]
        [Required]
        public string WhyUsText { get; set; }
        [Display(Name = "Contact Us Text")]
        [Required]
        public string ContactUsText { get; set; }

    }
}
