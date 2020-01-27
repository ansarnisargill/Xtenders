using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XtendersProject.Models
{
    public class Quotation
    {

        [Key]
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email  { get; set; }
        [Display(Name = "Detail")]
        public string Detail { get; set; }
    }
}