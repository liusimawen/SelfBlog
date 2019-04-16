using SelfBlog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelfBolg.Services
{
    public interface ICategoryService
    {
        CategoryEntity Get(int id);
        List<CategoryEntity> GetAll();
        int Add(CategoryEntity entity);
        int Update(CategoryEntity entity);
        int Delete(int id);
    }
    public class CategoryService : ICategoryService
    {
        private BlogDBContext _context = new BlogDBContext();
        public int Add(CategoryEntity entity)
        {
            _context.Category.Add(entity);
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            CategoryEntity category = _context.Category.Where(u => u.Id == id).FirstOrDefault();
            if (category != null)
                _context.Category.Remove(category);
            return _context.SaveChanges();
        }

        public CategoryEntity Get(int id)
        {
            return _context.Category.Where(u => u.Id == id).FirstOrDefault();
        }

        public List<CategoryEntity> GetAll()
        {
            return _context.Category.ToList();
        }

        public int Update(CategoryEntity entity)
        {
            CategoryEntity oldEntity = _context.Category.Where(s => s.Id == entity.Id).FirstOrDefault();
            entity.CreateTime = DateTime.Now;
            _context.Entry(oldEntity).CurrentValues.SetValues(entity);
            return _context.SaveChanges();
        }
    }
}
