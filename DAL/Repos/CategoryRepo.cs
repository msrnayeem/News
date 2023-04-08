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
        public static bool Add(Category category)
        {
            db.Categories.Add(category);
           return db.SaveChanges() > 0;
        }
        public static bool Update(Category category)
        {
            var exemp = Get(category.Id);
            db.Entry(exemp).CurrentValues.SetValues(category);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            return db.SaveChanges() > 0;
        }

        
    }
}
