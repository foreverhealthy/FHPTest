using FRPI.FHP.Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRPI.FHP.Core.Common.Data
{
    public abstract class DataRepositoryBase<T, U> : IDataRepository<T>
        where T : class, new()
        where U : DbContext, new()
    {
        protected abstract T AddEntity(U entityContext, T entity);
        protected abstract T UpdateEntity(U entityContext, T entity);
        protected abstract IEnumerable<T> GetEntities(U entityContext);
        protected abstract T GetEntity(U entityContext, int id);
        protected abstract IEnumerable<T> GetDataEntity(U entityContext, Func<T, bool> predicate);
        protected DbSet<T> DbSet { get; set; }
        protected DbContext DbContext
        {
            get
            {
                return new U();
            }
        }

        public List<T> ExecStoredProcedure(string storedProc, SqlParameter sqlParams)
        {
            using (U entityContext = new U())
            {
                if (sqlParams != null)
                    return entityContext.Database.SqlQuery<T>(storedProc, sqlParams).ToList();
                else
                    return entityContext.Database.SqlQuery<T>(storedProc).ToList();
            }

        }
        public T Add(T entity)
        {
            using (U entityContext = new U())
            {

                T addEntity = AddEntity(entityContext, entity);
                entityContext.SaveChanges();
                return addEntity;
            };
        }

        public void Remove(T entity)
        {
            using (U entityContext = new U())
            {

                entityContext.Entry<T>(entity).State = EntityState.Deleted;
                entityContext.SaveChanges();

            };
        }

        public void Remove(int id)
        {
            using (U entityContext = new U())
            {
                T entity = GetEntity(entityContext, id);
                entityContext.Entry<T>(entity).State = EntityState.Deleted;
                entityContext.SaveChanges();

            };
        }

        public T Update(T entity)
        {
            using (U entityContext = new U())
            {
                T existingEntity = UpdateEntity(entityContext, entity);

                if (existingEntity != null)
                {
                    entityContext.Entry(existingEntity).State = EntityState.Detached;
                }

                entityContext.Entry(entity).State = EntityState.Modified;

                entityContext.SaveChanges();

                return existingEntity;
            };
        }

        public IEnumerable<T> Get()
        {
            using (U entityContext = new U())
                return (GetEntities(entityContext)).ToArray().ToList();
        }

        public T Get(int id)
        {
            using (U entityContext = new U())
                return (GetEntity(entityContext, id));
        }

        public IEnumerable<T> GetData(Func<T, bool> predicate)
        {


            using (U entityContext = new U())
            {
                return GetDataEntity(entityContext, predicate).ToList();

            }


        }

        //Added code
        public IQueryable<T> ReturnQueryableList()
        {
            return this.DbSet.AsQueryable();
        }

        public IList<T> ReturnList()
        {
            return this.DbSet.ToList();
        }



    }
}

