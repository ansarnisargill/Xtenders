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

    }
}