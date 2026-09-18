using C__301_DataAccesLayer.Abstract;
using C__301_DataAccesLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__301_DataAccesLayer.Repositories
{
    public class Generic_Repository<T> : IGenericDal<T> where T : class
    {
        KampContext context = new KampContext();
        private readonly DbSet<T> _object;
        public Generic_Repository()
        {
            _object = context.Set<T>();
        }

        public void Delete(T entity)
        {
            var deletetEntity = context.Entry(entity);
            deletetEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntitiy = context.Entry(entity);
            addedEntitiy.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entitiy)
        {
            var updatedEntity = context.Entry(entitiy);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
