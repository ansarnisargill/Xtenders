using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XtendersProject.Models
{
    public class Product
    {

        [Key]
        public int ID { get; set; }
        [Display(Name = "Product Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Product Description")]
        [Required]
        public string Description { get; set; }
        [Display(Name = "Picture")]
        public string PicUrl { get; set; }
        public DateTime AddedDate { get; set; }=DateTime.Now;
        [NotMapped]
        public IFormFile Pic { get; set; }
    }
}