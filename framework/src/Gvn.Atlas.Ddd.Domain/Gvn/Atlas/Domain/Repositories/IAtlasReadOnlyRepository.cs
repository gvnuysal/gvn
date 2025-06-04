using Gvn.Atlas.Domain.Entities;

namespace Gvn.Atlas.Domain.Repositories;

public interface IAtlasReadOnlyRepository<TEntity> : IAtlasReadOnlyBasicRepository<TEntity>
    where TEntity : class, IAtlasEntity
{
}