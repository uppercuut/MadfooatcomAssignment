using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserSubManagementSystem.FrontEnd.Models.ViewModels
{
    public class User
    {
        public int id { get; set; }

        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }
        public string City { get; set; }

        public string Street { get; set; }
    }
}