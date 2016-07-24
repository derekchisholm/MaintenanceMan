using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MaintenanceMan.EntityFramework.Repositories
{
    public abstract class MaintenanceManRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MaintenanceManDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MaintenanceManRepositoryBase(IDbContextProvider<MaintenanceManDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MaintenanceManRepositoryBase<TEntity> : MaintenanceManRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MaintenanceManRepositoryBase(IDbContextProvider<MaintenanceManDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
