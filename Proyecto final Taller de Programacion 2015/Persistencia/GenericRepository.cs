using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Persistencia
{
    public class GenericRepository<TEntity> where TEntity : class
    {       
   
        internal CarteleriaContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(CarteleriaContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            context.Entry(entityToUpdate).State = EntityState.Modified;
            dbSet.Attach(entityToUpdate);            
        }

        public IQueryable<TEntity> Queryable{get {return this.dbSet;}}

    }
}
