using AutoMapper;
using NewsWebApp.BLL.DTO;
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
    class NewsManagerController : Controller
    {
        INewsManagerService _newsManagerService;

        public NewsManagerController(INewsManagerService newsManagerService)
        {
            _newsManagerService = newsManagerService;
        }

        public List<NewsViewModel> GetNews()
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<NewsDTO, NewsViewModel>()).CreateMapper();
            return mapper.Map<IEnumerable<NewsDTO>, List<NewsViewModel>>(_newsManagerService.GetNews());
        }

        public AuthorViewModel GetAuthorView(int? id)
        {
            AuthorDTO authorDTO = _newsManagerService.GetAuthor(id);
            return new AuthorViewModel
            {
                Id = authorDTO.Id,
                Username = authorDTO.Username,
                Firstname = authorDTO.Firstname,
                Lastname = authorDTO.Lastname,
                Email = authorDTO.Email,
                Mobile = authorDTO.Mobile,
                RegistrationDate = authorDTO.RegistrationDate
            };
        }

        public HeadingViewModel GetHeadingView(int? id)
        {
            HeadingDTO headingDTO = _newsManagerService.GetHeading(id);
            return new HeadingViewModel
            {
                Id = headingDTO.Id,
                Name = headingDTO.Name
            };
        }

        public List<NewsViewModel> GetByTopic(string topyc)
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<NewsDTO, NewsViewModel>()).CreateMapper();
            return mapper.Map<IEnumerable<NewsDTO>, List<NewsViewModel>>(_newsManagerService.GetNewsByTopic(topyc));
        }
        public List<NewsViewModel> GetByHeading(int? id) 
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<NewsDTO, NewsViewModel>()).CreateMapper();
            return mapper.Map<IEnumerable<NewsDTO>, List<NewsViewModel>>(_newsManagerService.GetNewsByHeading(id));
        }

        public List<NewsViewModel> GetByDate(DateTime date1, DateTime date2)
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<NewsDTO, NewsViewModel>()).CreateMapper();
            return mapper.Map<IEnumerable<NewsDTO>, List<NewsViewModel>>(_newsManagerService.GetNewsByDate(date1, date2));
        }
        public List<NewsViewModel> GetByName(string name)
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<NewsDTO, NewsViewModel>()).CreateMapper();
            return mapper.Map<IEnumerable<NewsDTO>, List<NewsViewModel>>(_newsManagerService.GetNewsByName(name));
        }

        protected override void Dispose(bool disposing)
        {
            _newsManagerService.Dispose();
            base.Dispose(disposing);
        }
    }
}
