using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }
        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }
        public List<Article> TGettAll()
        {
            return _articleDal.GettAll();
        }
        public void TInsert(Article entity)
        {
            _articleDal.Insert(entity);
        }
        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }
    }
}
