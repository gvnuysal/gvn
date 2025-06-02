namespace Gvn.Atlas.Auditing;

public interface IAtlasFullAuditedObject : IAtlasAuditedObject, IAtlasDeletionAuditedObject
{
}

public interface IAtlasFullAuditedObject<TUser> : IAtlasAuditedObject<TUser>, IAtlasFullAuditedObject,
    IAtlasDeletionAuditedObject<TUser>
{
    
}