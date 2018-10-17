using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using UserSubManagementSystem.FrontEnd.Models.ViewModels;

namespace UserSubManagementSystem.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
       
      
        public ActionResult CreateUser()
        {


   
            return View();
        }

        [System.Web.Http.HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> AddUserAsync(string TimeStamp, string SdrCode, [FromBody] User user)
        {
            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                 response = await client.PostAsync(
                    "http://localhost:50234/api/UserApi/CreateUser",
                     new StringContent(JsonConvert.SerializeObject(new {TimeStamp = TimeStamp,
                         SdrCode = SdrCode,
                         PrsnlInfo = new { Name = user.Name, DateOfBirth = user.DateOfBirth, Mobile= user.Mobile, Email = user.Email} ,
                         AdrsInfo = new { Country = user.Country, City  = user.City, Street = user .Street}
                     }), Encoding.UTF8, "application/json"));
            }    
            return Redirect("/Home/CreateUser?Success=" + response.IsSuccessStatusCode);
        }


        public ActionResult ViewAllUsers()
        {
            string contents="";
            using (var wc = new System.Net.WebClient())
                contents = wc.DownloadString("http://localhost:50234/api/UserApi/GetAll");
            UsersViewModel list = JsonConvert.DeserializeObject<UsersViewModel>(contents);
            return View("/Views/Home/ViewAllUsers.cshtml", "/Views/Shared/_Layout.cshtml", list);
        }
  
    }
}