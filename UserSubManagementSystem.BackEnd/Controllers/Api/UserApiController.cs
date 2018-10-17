using System;
using System.Linq;
using System.Web.Http;
using UserSubManagementSystem.BackEnd.Core;
using UserSubManagementSystem.BackEnd.Models.ViewModels;


namespace UserSubManagementSystem.BackEnd.Controllers.Api
{
    public class UserApiController : ApiController
    {
        private IUnitOfWork _UintOfWork;
        public UserApiController(IUnitOfWork UintOfWork)
        {
            _UintOfWork = UintOfWork;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(new { TmStp=DateTime.Now , SdrCode= new Random().Next() , Users = _UintOfWork.Users.GetAll()});
        }

        [HttpPost]
        public IHttpActionResult CreateUser(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
             var ModelErrors=ModelState.Where(x => x.Value.Errors.Count > 0);
                return BadRequest("Please Check the Validation");
            }

            _UintOfWork.Users.Add(new Core.Domain.User()
            {
                Name = user.PrsnlInfo.Name,
                City = user.AdrsInfo.City,
                Country = user.AdrsInfo.Country,
                DateOfBirth = user.PrsnlInfo.DateOfBirth,
                Email = user.PrsnlInfo.Email,
                Mobile = user.PrsnlInfo.Mobile,
                Street = user.AdrsInfo.Street
            });
            _UintOfWork.Complete();
            return Ok(new { errors = false , errorDesc = "success, user added.", TmStp = user.TimeStamp , SdrCode = user.SdrCode });         
        }
    }


}
