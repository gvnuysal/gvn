namespace Gvn.Atlas.Domain.Entities;

public interface IAtlasEntity
{
    object?[] GetKeys();
}

public interface IAtlasEntity<TId> : IAtlasEntity
{
    TId Id { get; }
}