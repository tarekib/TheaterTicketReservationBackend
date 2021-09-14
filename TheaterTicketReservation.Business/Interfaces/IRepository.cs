using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TheaterTicketReservation.BL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // Get Data 
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll(string[] children = null);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        // Add Data 
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        // Update Data 
        void Update(TEntity entity);

        // Remove Data 
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
