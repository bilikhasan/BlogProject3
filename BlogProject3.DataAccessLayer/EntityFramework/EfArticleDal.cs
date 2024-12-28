using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.DataAccessLayer.Context;
using BlogProject3.DataAccessLayer.Repositories;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
