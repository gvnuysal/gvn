using System;
using System.Collections.Generic;

namespace Gvn.Atlas.Application.Dtos;

[Serializable]
public class AtlasListResultDto<T> : IAtlasListResultDto<T>
{
    private IReadOnlyList<T>? _items;

    public IReadOnlyList<T> Items
    {
        get { return _items ??= new List<T>(); }
        set => _items = value;
    }

    public AtlasListResultDto()
    {
        
    }

    public AtlasListResultDto(IReadOnlyList<T> items)
    {
        Items = items;
    }
    
}