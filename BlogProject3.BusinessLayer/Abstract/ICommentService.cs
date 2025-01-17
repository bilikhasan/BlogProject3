﻿using BlogProject3.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.BusinessLayer.Abstract
{
    public interface ICommentService :IGenericService<Comment>
    {
        public List<Comment> TGetCommentsByArticleId(int id);

        public List<Comment> TGetCommentsByAppUserId(int id);


    }
}
