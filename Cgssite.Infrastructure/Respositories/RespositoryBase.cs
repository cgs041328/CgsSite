using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Cgssite.Infrastructure.Respositories
{
    public class RespositoryBase<TEntity>:IDisposable where TEntity:class
    {
        protected CgsContext db;
        public IEnumerable<TEntity> Get()
        {
            return db.Set<TEntity>().ToList();
        }
        public TEntity Get(Guid id)
        {
            return db.Set<TEntity>().Find(id);
        }
        public void Create(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            db.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            db.Entry<TEntity>().State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
            db.SaveChanges();
        }
        public void Dipose()
        {
            db.Dispose();
        }
    }
}
