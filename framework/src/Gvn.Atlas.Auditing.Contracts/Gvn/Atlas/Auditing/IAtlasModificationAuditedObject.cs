using System;

namespace Gvn.Atlas.Auditing;

public interface IAtlasModificationAuditedObject:IAtlasHasModificationTime
{
    Guid? LastModifierUserId { get; set; }
}

public interface IAtlasModificationAuditedObject<TUser> : IAtlasModificationAuditedObject
{
    TUser? LastModifierUser { get; set; }
}