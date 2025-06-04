using System;
using System.Collections.Generic;

namespace Gvn.Atlas.Application.Dtos;

[Serializable]
public class AtlasPagedResultDto<T>:AtlasListResultDto<T>,IAtlasPagedResultDto<T>
{
    public long TotalCount { get; }

    public AtlasPagedResultDto()
    {
        
    }

    public AtlasPagedResultDto(long totalCount,IReadOnlyList<T> items):base(items)
    {
        
    }
}