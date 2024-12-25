using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.DataAccessLayer.Abstract
{
    public interface IGenericDal <T> where T :class
    {
        void Insert (T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GettAll();
        T GetById(int id);

    }
}
