using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PledgeAThon.DataLayer.UnitOfWork;

namespace PledgeAThon.DataLayer.Repository
{
    public interface IRepository<TEntity,TPrimaryKey>
    {


        /// <summary>
        /// Flushes content of unit of work to the underlying data storage.
        /// </summary>
        void Flush();

        /// <summary>
        /// Inserts entity to the storage.
        /// </summary>
        void Insert(TEntity entity);

        /// <summary>
        /// Updates entity in the storage.
        /// </summary>
        void Update(TEntity entity);

        /// <summary>
        /// Deletes entity in the storage.
        /// </summary>
        void Delete(TEntity entity);

        /// <summary>
        /// Gets entity from the storage by it's Id.
        /// </summary>
        TEntity GetById(TPrimaryKey id);

        /// <summary>
        /// Gets all entities of the type from the storage. 
        /// </summary>
        IList<TEntity> GetAll();
    }
}
