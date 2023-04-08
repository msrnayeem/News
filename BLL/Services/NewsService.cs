using BLL.DTOs;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NewsService
    {
        public static List<NewsDTO> GetAll()
        {
            var data = NewsRepo.GetAll();
            return Convert(data);
        }
        public static NewsDTO Get(int id)
        {
            var data = NewsRepo.Get(id);
            return Convert(data);
        }
        public static bool Add(NewsDTO news)
        {
            var data = Convert(news);
            return NewsRepo.Add(data);
        }
        public static bool Update(News news)
        {
            return NewsRepo.Update(news);
        }
        public static bool Delete(int id)
        {
            return NewsRepo.Delete(id);
        }



        static NewsDTO Convert(News news)
        {
            return new NewsDTO()
            {
                Id = news.Id,
                Title = news.Title,
                Description = news.Description,
                Date = news.Date,
                CategoryId = news.CategoryId
            };
        }

        static News Convert(NewsDTO news)
        {
            return new News()
            {
                Id = news.Id,
                Title = news.Title,
                Description = news.Description,
                Date = news.Date,
                CategoryId = news.CategoryId
            };
        }
        static List<NewsDTO> Convert(List<News> news)
        {
            return news.Select(x => Convert(x)).ToList();
        }
    }
}
