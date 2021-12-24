using AutoMapper;
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
    public class PublishNewController : Controller
    {
        INewsPublishService _newsPublishService;

        public PublishNewController(INewsPublishService newsPublid)
        {
            _newsPublishService = newsPublid;
        }

        public List<HeadingViewModel> GetHeadings()
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<HeadingDTO, HeadingViewModel>()).CreateMapper();
            return mapper.Map<IEnumerable<HeadingDTO>, List<HeadingViewModel>>(_newsPublishService.GetHeadings());
        } 

        public string Publish(NewsViewModel news)
        {
            NewsDTO newsDTO = new NewsDTO
            {
                NewsName = news.NewsName,
                NewsText = news.NewsText,
                Topyc = news.Topyc,
                AuthorId = news.AuthorId,
                HeadingId = news.HeadingId
            };

            try
            {
                _newsPublishService.PublishNews(newsDTO);
                return "Pusblish success!";
            }
            catch(ValidationException ex)
            {
                return ex.Message;
            }

        }


        protected override void Dispose(bool disposing)
        {
            _newsPublishService.Dispose();
            base.Dispose(disposing);
        }
    }
}
