using System;
using JetBrains.Annotations;

namespace Gvn.Atlas.Auditing;

public interface IAtlasMustHaveCreator<TCreator>:IAtlasMustHaveCreator
{
    [NotNull]
    TCreator Creator { get; set; }
}

public interface IAtlasMustHaveCreator
{
    Guid  CreatorId { get; }
}