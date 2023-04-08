using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo
    {
        static NewsContext db;
        static NewsRepo()
        {
            db = new NewsContext();
        }
        public static List<News> GetAll()
        {
            return db.News.ToList();
        }
        public static News Get(int id)
        {
            return db.News.Find(id);
        }
        public static bool Add(News news)
        {
            db.News.Add(news);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id)
        {
            News news = db.News.Find(id);
            db.News.Remove(news);
           return  db.SaveChanges() > 0;
        }
        public static bool Update(News news)
        {
            db.Entry(news).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
