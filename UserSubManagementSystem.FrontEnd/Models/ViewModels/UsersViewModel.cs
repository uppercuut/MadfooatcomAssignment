using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserSubManagementSystem.FrontEnd.Models.ViewModels
{
    public class UsersViewModel
    {
        public string TmStp { get; set; }
     
        public int SdrCode { get; set; }

        public List<User> Users { get; set; }




    }
}