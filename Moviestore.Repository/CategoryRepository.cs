using Bookstore.Entities;
using Moviesite.Data;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moviestore.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            this._context = context;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            Category category = GetCategoryById(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public void EditCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var allCategories = _context.Categories.AsEnumerable();
            return allCategories;
        }

        public Category GetCategoryById(int id)
        {
            var result = _context.Categories.FirstOrDefault(category => category.Id == id);
            return result;
        }
    }
}
