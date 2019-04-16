using SelfBlog.Entities;
using SelfBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelfBolg.Services
{
    public interface IArticleService
    {
        ArticleEntity Get(int id);
        /// <summary>
        /// 获取上一篇
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ArticleEntity GetPrevById(int id);
        /// <summary>
        /// 获取下一篇
        /// </summary>
        /// <param name="">id</param>
        /// <returns></returns>
        ArticleEntity GetNextById(int id);
        int Add(ArticleEntity entity);
        int Update(ArticleEntity entity);
        int Delete(int id);
        bool ExistByCategoryId(int categoryId);

        PagedList<ArticleEntity> GetPagedList(int page, int pageSize, int categoryId);

        long GetCountByCategoryId(int categoryId);
    }
    public class ArticleService : IArticleService
    {
        private BlogDBContext _context = new BlogDBContext();
        public int Add(ArticleEntity entity)
        {
            _context.Article.Add(entity);
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            ArticleEntity entity = _context.Article.Where(u => u.Id == id).FirstOrDefault();
            if (entity != null)
                _context.Article.Remove(entity);
            return _context.SaveChanges();
        }

        public bool ExistByCategoryId(int categoryId)
        {
            return _context.Article.Where(s => s.CategoryId == categoryId).Count() != 0;
        }

        public ArticleEntity Get(int id)
        {
            return _context.Article.Where(u => u.Id == id).FirstOrDefault();
        }

        public long GetCountByCategoryId(int categoryId)
        {
            return _context.Article.Where(s => s.CategoryId == categoryId).Count();
        }

        public ArticleEntity GetNextById(int id)
        {
            return _context.Article.Where(s => s.Id > id).OrderBy(s => s.Id).FirstOrDefault();
        }

        public PagedList<ArticleEntity> GetPagedList(int page, int pageSize, int categoryId)
        {
            List<ArticleEntity> articleList = _context.Article.ToList();
            int row = (page - 1) * pageSize;
            IEnumerable<ArticleEntity> records = articleList;
            //-1表示获取所有文章
            if (categoryId != -1)
                records = articleList.Where(s => s.CategoryId == categoryId);
            records = records.Skip(row).Take(pageSize).ToList();
            return records.ToPaged(page, pageSize, articleList.Count);
        }

        public ArticleEntity GetPrevById(int id)
        {
            return _context.Article.Where(s => s.Id < id).OrderByDescending(s => s.Id).FirstOrDefault();
        }

        public int Update(ArticleEntity entity)
        {
            ArticleEntity oldEntity = _context.Article.Where(s => s.Id == entity.Id).FirstOrDefault();
            entity.CreateTime = DateTime.Now;
            _context.Entry(oldEntity).CurrentValues.SetValues(entity);
            return _context.SaveChanges();
        } 
    }
}
