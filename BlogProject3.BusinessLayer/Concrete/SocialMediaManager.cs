using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.DataAccessLayer.EntityFramework;
using BlogProject3.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public void TDelete(int id)
        {
            _socialMediaDal.Delete(id);
        }
        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }
        public List<SocialMedia> TGettAll()
        {
            return _socialMediaDal.GettAll();
        }
        public void TInsert(SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }
        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
