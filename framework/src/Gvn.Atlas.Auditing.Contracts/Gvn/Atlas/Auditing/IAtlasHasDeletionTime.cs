using System;

namespace Gvn.Atlas.Auditing;

public interface IAtlasHasDeletionTime:IAtlasSoftDelete
{
    DateTime? DeletionTime { get;}
}