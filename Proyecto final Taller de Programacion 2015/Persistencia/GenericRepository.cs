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

        /// <summary>
        /// Constructor del repositorio generico
        /// </summary>
        /// <param name="context">contexto con el que trabajamos</param>
        public GenericRepository(CarteleriaContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        #region Metodos
        /// <summary>
        /// Metodo para obtener una entidad a traves de su id
        /// </summary>
        /// <param name="id">objeto que contiene la id de la entidad</param>
        /// <returns></returns>
        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// Metodo para insertar una entidad a la base de datos
        /// </summary>
        /// <param name="entity">entidad a insertar en la BD</param>
        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        /// <summary>
        /// Metodo para eliminar una entidad de la BD
        /// </summary>
        /// <param name="id">objeto que contiene la id de la entidad a eliminar</param>
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// Metodo para eliminar una entidad de la BD
        /// </summary>
        /// <param name="entityToDelete">objeto que contiene la entidad a eliminar</param>
        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Metodo para modificar una entidad de la BD
        /// </summary>
        /// <param name="entityToUpdate">objeto que contiene la entidad a modificar</param>
        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;                        
        }

        /// <summary>
        /// Metodo para obtener la lista de todas las objetos de un tipo de entidad (o clase)
        /// </summary>
        public IQueryable<TEntity> Queryable{get {return this.dbSet;} }
        #endregion

    }
}
