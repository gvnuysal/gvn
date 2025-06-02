namespace Gvn.Atlas.Auditing;

public interface IAtlasCreationAuditedObject:IAtlasHasCreationTime,IAtlasMustHaveCreator
{
    
}

public interface IAtlasCreationAuditedObject<TCreator> : IAtlasCreationAuditedObject, IAtlasMustHaveCreator<TCreator>
{
    
}