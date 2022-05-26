using System;
using System.ComponentModel.DataAnnotations;

namespace Deepika.Models
{
    public class Hospital
    {

        [Required(ErrorMessage = "Please enter Hospital name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please enter the Hospital Address")]
        public string Address { get; set; }
       
        [Required(ErrorMessage = "Please select the speciality")]
        public string Speciality { get; set; }

    }
}
