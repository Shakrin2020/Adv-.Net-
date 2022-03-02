using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;        // have to include this for [Required]
using System.Linq;
using System.Web;

namespace LabTask_1.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please fill your name")]
        [StringLength(10, ErrorMessage = "Maximum length is 50")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "ID must follow XX-XXXXX-X")] // d -> numeric. first 2 d, then dash, then 5 d, then desh, then 1 d. Like our ID
        public string Id{ get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]
        public string Email { get; set; }
    }
}