using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserSubManagementSystem.BackEnd.Models.ViewModels
{
    public class UserViewModel
    {
        [DataType(DataType.DateTime)]
        public string TimeStamp { get; set; }
        [Required]
        public int SdrCode { get; set; }
        [Required]
        public PersonalInfoViewModel PrsnlInfo { get; set; }
        [Required]
        public AddressInfoViewModel AdrsInfo { get; set; }




    }
}