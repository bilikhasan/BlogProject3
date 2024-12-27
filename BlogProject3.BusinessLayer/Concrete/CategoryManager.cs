using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.EntityLayer.Concrete;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;                 //Sıfırdan oluşturdum
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public List<Category> TGettAll()
        {
            return _categoryDal.GettAll();
        }
        public void TInsert(Category entity)
        {
            if(entity.CategoryName.Length>=5 && entity.CategoryName.Length<=50)
            {
                _categoryDal.Insert(entity);
            }
            else
            {
                //hata mesajı buraya verilecek.
            }
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
