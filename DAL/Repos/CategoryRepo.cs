using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        static NewsContext db;
        static CategoryRepo()
        {
            db = new NewsContext();
        }
        public static List<Category> GetAll()
        {
            return db.Categories.ToList();
        }
        public static Category Get(int id)
        {
            return db.Categories.Find(id);
        }
        public static void Add(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }
        public static void Update(Category category)
        {
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public static void Delete(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }
}
