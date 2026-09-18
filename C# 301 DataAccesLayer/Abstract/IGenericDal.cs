using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__301_DataAccesLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
        List<T> GetAll();
        T GetById(int id);
    }
}
