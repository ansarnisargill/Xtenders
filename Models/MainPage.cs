using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace XtendersProject.Models
{
    public class HomePageData
    {

        [Key]
        public int ID { get; set; }
        [Display(Name = "Main Tag Line")]
        [Required]
        public string TagLine { get; set; }
        [Display(Name = "Main Intro")]
        [Required]
        public string MainIntro { get; set; }
        [Display(Name = "Announcement")]
        [Required]
        public string Announcement { get; set; }
        [Display(Name = "Quality Product Heading")]
        [Required]
        public string QualityProductHeading { get; set; }
        [Display(Name = "Customer Service Heading")]
        [Required]
        public string CustomerServiceHeading { get; set; }
        [Display(Name = "Delivery Heading")]
        [Required]
        public string DeliveryHeading { get; set; }


        [Display(Name = "Quality Product Text")]
        [Required]
        public string QualityProductText { get; set; }
        [Display(Name = "Customer Service Text")]
        [Required]
        public string CustomerServiceText { get; set; }
        [Display(Name = "Delivery Text")]
        [Required]
        public string DeliveryText { get; set; }
        [Display(Name = "Product Headline")]
        [Required]
        public string ProductHeading { get; set; }
        [Display(Name = "Products Intro")]
        [Required]
        public string ProductIntro { get; set; }

    }
}