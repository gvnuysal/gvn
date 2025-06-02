using System;

namespace Gvn.Atlas.Auditing;

public interface IAtlasHasModificationTime
{
    /// <summary>
    /// Bir entity ye ait en son güncelleme verisini tutacak
    /// </summary>
    DateTime? LastModificationTime { get;}
}