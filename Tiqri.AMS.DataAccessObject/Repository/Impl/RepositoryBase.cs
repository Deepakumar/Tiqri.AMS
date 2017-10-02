using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Tiqri.AMS.DataAccessObject.Interface;
using Tiqri.AMS.Model;
using Tiqri.AMS.Model.Enum;

namespace Tiqri.AMS.DataAccessObject
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        DbSet<T> dbSet;
        DbContext dbContext;

        public RepositoryBase() : this(new AmsDbContext()) { }

        public RepositoryBase(AmsDbContext context)
        {
            lock (context)
            {
                dbContext = context;
                dbSet = context.Set<T>();
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var transaction = dbContext.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    var entity = GetProxy(t => t.ID == id);
                    dbSet.Attach(entity);
                    dbSet.Remove(entity);
                    dbContext.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
            }

        }

        public IList<T> GetAll()
        {
            return dbSet.ToList<T>();
        }

        public IList<T> GetAll(Expression<Func<T, bool>> whereCondition)
        {
            return dbSet.Where(whereCondition).ToList<T>();
        }

        public T GetProxy(Expression<Func<T, bool>> whereCondition)
        {
            var returnValue = dbSet.Where(whereCondition).FirstOrDefault<T>();
            if (returnValue != null)
                returnValue.State = State.Unchanged;
            return returnValue;
        }

        public IQueryable<T> GetQueryable()
        {
            return this.dbSet.AsQueryable<T>();
        }

        public T GetSingle(Expression<Func<T, bool>> whereCondition)
        {
            return dbSet.Where(whereCondition).FirstOrDefault();
        }

        public int Save(T entity)
        {
            int returnValue = 0;
            dbSet.Add(entity);

            foreach (var entry in dbContext.ChangeTracker.Entries<EntityBase>())
            {
                try
                {
                    EntityBase stateInfo = entry.Entity;
                    entry.State = ConvertState(stateInfo.State);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            returnValue = dbContext.SaveChanges();
            entity.State = State.Unchanged;
            return returnValue;
        }

        private EntityState ConvertState(State state)
        {
            switch (state)
            {
                case State.Added:
                    return EntityState.Added;
                case State.Modified:
                    return EntityState.Modified;
                case State.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

    }

}
