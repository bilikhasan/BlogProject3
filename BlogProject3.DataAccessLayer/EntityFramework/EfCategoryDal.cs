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
    }
}
