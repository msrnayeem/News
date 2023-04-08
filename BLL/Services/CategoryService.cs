using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService
    {
        public static List<Category> GetAll()
        {
            return CategoryRepo.GetAll();
        }
        public static Category Get(int id)
        {
            return CategoryRepo.Get(id);
        }
        public static void Add(Category category)
        {
            CategoryRepo.Add(category);
        }
        public static void Update(Category category)
        {
            CategoryRepo.Update(category);
        }
        public static void Delete(int id)
        {
            CategoryRepo.Delete(id);
        }
    }
}
