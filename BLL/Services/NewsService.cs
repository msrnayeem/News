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
        public static List<News> GetAll()
        {
            return NewsRepo.GetAll();
        }
        public static News Get(int id)
        {
            return NewsRepo.Get(id);
        }
        public static void Add(News news)
        {
            NewsRepo.Add(news);
        }
        public static void Update(News news)
        {
            NewsRepo.Update(news);
        }
        public static void Delete(int id)
        {
            NewsRepo.Delete(id);
        }
    }
}
