﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(int id);
        List<T> TGettAll();
        T TGetById(int id);
    }
}