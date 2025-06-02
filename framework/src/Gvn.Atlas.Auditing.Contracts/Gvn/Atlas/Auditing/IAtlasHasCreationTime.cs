using System;

namespace Gvn.Atlas.Auditing;

public interface IAtlasHasCreationTime
{
    /// <summary>
    /// Creation Time
    /// </summary>
    DateTime CreationTime { get;}
}