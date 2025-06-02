using System;

namespace Gvn.Atlas.Application.Dtos;

[Serializable]
public abstract class AtlasEntityDto : IAtlasEntityDto
{
}

[Serializable]
public abstract class AtlasEntityDto<TId> : AtlasEntityDto, IAtlasEntityDto<TId>
{
    /// <summary>
    /// Entity ye ait olan key bilgisi
    /// </summary>
    public TId Id { get; set; } = default!;
}