using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.DataAccessLayer.Context;
using BlogProject3.DataAccessLayer.Repositories;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(BlogContext context) : base(context)
        {
        }
        public List<Article> ArticleListWithCategory()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x => x.Category).ToList();
            return values;
        }
        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x => x.Category).Include(y => y.AppUser).ToList();
            return values;
        }
        public Article ArticleListWithCategoryAndAppUserByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.ArticleId == id).Include(y => y.Category).Include(z => z.AppUser).FirstOrDefault();
            return values;
        }
        public void ArticleViewCountIncrease(int id)
        {
            var context = new BlogContext();
            var updatedValue = context.Articles.Find(id);
            updatedValue.ArticleViewCount += 1;
            context.SaveChanges();
        }






        public Article GetAboutWriter(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.ArticleId == id).Include(y => y.AppUser).FirstOrDefault();
            return values;
        }

        public List<Article> GetArticlesByAppUserId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.AppUserId == id).ToList();
            return values;
        }

        public List<Article> LastThreeArticles()
        {
            var context = new BlogContext();
            var values = context.Articles.OrderByDescending(x => x.ArticleId).Take(3).ToList();
            return values;
        }

        public List<Article> PopularArticles()
        {
            var context = new BlogContext();
            var values = context.Articles.OrderByDescending(x => x.ArticleViewCount).Take(3).ToList();
            return values;
        }

    }
}
