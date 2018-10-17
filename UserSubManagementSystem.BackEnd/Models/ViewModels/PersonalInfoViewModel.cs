using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserSubManagementSystem.BackEnd.Models.ViewModels
{
    public class PersonalInfoViewModel
    {
        [Required]
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [Required]
        [Phone]
        public string Mobile { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}