namespace Gvn.Atlas.Auditing;

public interface IAtlasAuditedObject : IAtlasCreationAuditedObject, IAtlasModificationAuditedObject
{
}

public interface IAtlasAuditedObject<TUser> : IAtlasAuditedObject, IAtlasCreationAuditedObject<TUser>,
    IAtlasModificationAuditedObject<TUser>
{
}