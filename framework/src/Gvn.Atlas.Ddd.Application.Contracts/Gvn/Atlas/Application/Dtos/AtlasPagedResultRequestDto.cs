using System;
using System.ComponentModel.DataAnnotations;

namespace Gvn.Atlas.Application.Dtos;

[Serializable]
public class AtlasPagedResultRequestDto:AtlasLimitedResultRequestDto,IAtlasPagedResultRequestDto
{
    [Range(0,int.MaxValue)]
    public int Skip { get; set; }
}