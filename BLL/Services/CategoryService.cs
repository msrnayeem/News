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
    public class CategoryService
    {
        public static List<CategoryDTO> GetAll()
        {
            var data = CategoryRepo.GetAll();
            return Convert(data);
        }
        public static Category Get(int id)
        {
            return CategoryRepo.Get(id);
        }
        public static bool Add(CategoryDTO category)
        {
            var data = Convert(category);
            return CategoryRepo.Add(data);
            
        }
        public static bool Update(CategoryDTO category)
        {
            var data = Convert(category);
            return CategoryRepo.Update(data);
        }
        public static bool Delete(int id)
        {
            return CategoryRepo.Delete(id);
        }

        static CategoryDTO Convert(Category category)
        {
            return new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name
            };
        }
        static Category Convert(CategoryDTO category)
        {
            return new Category()
            {
                Id = category.Id,
                Name = category.Name
            };
        }

        static List<CategoryDTO> Convert(List<Category> category)
        {
            return category.Select(x => Convert(x)).ToList();
        }
    }
}
