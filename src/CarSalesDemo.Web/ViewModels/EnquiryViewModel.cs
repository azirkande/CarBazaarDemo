using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesDemo.Web.ViewModels
{
    public class EnquiryViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(minimum: 1, maximum: int.MaxValue)]
        public int CarId { get; set; }
    }
}
