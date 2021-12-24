using NewsWebApp.BLL.DTO;
using NewsWebApp.BLL.Infrastructure;
using NewsWebApp.BLL.Interfaces;
using NewsWebApp.PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NewsWebApp.PL.Controllers
{
    class AutorisationController : Controller
    {
        private IAutoresationService _autorisationService;
        
        public AutorisationController(IAutoresationService service)
        {
            _autorisationService = service;
        }

        public string Register(AuthorViewModel user)
        {
            AuthorDTO authorDTO = new AuthorDTO
            {
                Email = user.Email,
                Username = user.Username,
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Password = user.Password
            };

            try
            {
                _autorisationService.RegistrateUser(authorDTO);
            }
            catch (ValidationException ex)
            {
                return ex.Message;
            }
            return $"User { user.Username } registered succesfully ";
        }

        public AuthorViewModel LogIn(string username, string passhash)
        {
            try
            {
                AuthorDTO authorDTO = _autorisationService.LogIn(username, passhash);

                return new AuthorViewModel
                {
                    Id = authorDTO.Id,
                    Username = authorDTO.Username,
                    Firstname = authorDTO.Firstname,
                    Lastname = authorDTO.Lastname,
                    Email = authorDTO.Email,
                    RegistrationDate = authorDTO.RegistrationDate,
                    Mobile = authorDTO.Mobile,
                    Password = authorDTO.Password,
                    Status = "OK"
                };

            }
            catch(ValidationException ex)
            {
                return new AuthorViewModel { Status = ex.Message };
            }
        }

        protected override void Dispose(bool disposing)
        {
            _autorisationService.Dispose();
            base.Dispose(disposing);
        }
    }
}
