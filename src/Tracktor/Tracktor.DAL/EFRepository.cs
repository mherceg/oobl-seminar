#region Using Namespaces...

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using Tracktor.DAL.Database;

#endregion

namespace Tracktor.DAL.EFRepository
{
    /// <summary>
    /// Generic Repository class for Entity Operations
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class EFRepository<DEntity,TEntity>
        where DEntity : class
        where TEntity : class
    {
        #region Private member variables...
        internal TracktorDb Context;
        internal DbSet<TEntity> DbSet;
        internal ModelMapper Mapper;
        #endregion

        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public EFRepository(TracktorDb context)
        {
            this.Context = context;
            this.DbSet = context.Set<TEntity>();
            this.Mapper = new ModelMapper();
        }
        #endregion

    }
}