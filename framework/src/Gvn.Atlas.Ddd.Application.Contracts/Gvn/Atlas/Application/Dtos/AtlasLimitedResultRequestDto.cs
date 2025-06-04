using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gvn.Atlas.Application.Dtos;

[Serializable]
public class AtlasLimitedResultRequestDto : IAtlasLimitedResultRequestDto, IValidatableObject
{
    public static int MaxMaxResultCount { get; set; } = 1000;
    public static int DefaultMaxResultCount = 10;
    [Range(1, int.MaxValue)] public int MaxResultCount { get; set; } = DefaultMaxResultCount;

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (MaxResultCount > MaxMaxResultCount)
        {
            yield return new ValidationResult("MaxResultCount Aşıldı.",
                new[] { nameof(MaxResultCount) });
        }
    }
}