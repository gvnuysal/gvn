using System;

namespace Gvn.Atlas.Auditing;

public interface IAtlasDeletionAuditedObject:IAtlasHasDeletionTime
{
    Guid? DeletionBy { get;}
}
public interface IAtlasDeletionAuditedObject<TUser>:IAtlasDeletionAuditedObject
{
    TUser? DeleterUser { get;}
}