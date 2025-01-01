using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.DataAccessLayer.Context;
using BlogProject3.DataAccessLayer.Repositories;
using BlogProject3.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(BlogContext context) : base(context)
        {

        }

        public List<Category> ArticleCountGroupedByCategory()
        {
            var context = new BlogContext();
            var values = context.Categories.OrderByDescending(x => x.CategoryArticleCount).ToList();
            return values;
        }

        public List<Category> PopularCategories()
        {
            var context = new BlogContext();
            var values = context.Categories.OrderByDescending(x => x.CategoryArticleCount).ToList();
            return values;
        }
    }
}
