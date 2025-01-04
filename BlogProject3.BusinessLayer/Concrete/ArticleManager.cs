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
        public List<Article> TArticleListWithCategory()
        {
            return _articleDal.ArticleListWithCategory();
        }

        public List<Article> TArticleListWithCategoryAndAppUser()
        {
            return _articleDal.ArticleListWithCategoryAndAppUser();
        }

        public Article TArticleListWithCategoryAndAppUserByArticleId(int id)
        {
            return _articleDal.ArticleListWithCategoryAndAppUserByArticleId(id);
        }

        public void TArticleViewCountIncrease(int id)
        {
            _articleDal.ArticleViewCountIncrease(id);
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public Article TGetAboutWriter(int id)
        {
            return _articleDal.GetAboutWriter(id);
        }

        public List<Article> TGetArticlesByAppUserId(int id)
        {
            return _articleDal.GetArticlesByAppUserId(id);
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
        public List<Article> TLastThreeArticles()
        {
            return _articleDal.LastThreeArticles();
        }
        public List<Article> TPopularArticles()
        {
            return _articleDal.PopularArticles();
        }
        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }
    }
}
