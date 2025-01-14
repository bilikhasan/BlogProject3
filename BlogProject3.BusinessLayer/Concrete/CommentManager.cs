﻿using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {

        private readonly ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void TDelete(int id)
        {
            _commentDal.Delete(id);
        }
        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetCommentsByAppUserId(int id)
        {
            return _commentDal.GetCommentsByAppUserId(id);
        }

        public List<Comment> TGetCommentsByArticleId(int id)
        {
            return _commentDal.GetCommentsByArticleId(id);
        }
        public List<Comment> TGettAll()
        {
            return _commentDal.GettAll();
        }
        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);
        }
        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
