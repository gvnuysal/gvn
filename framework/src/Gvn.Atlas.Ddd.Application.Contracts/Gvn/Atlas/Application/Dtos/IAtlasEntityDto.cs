namespace Gvn.Atlas.Application.Dtos
{
    public interface IAtlasEntityDto
    {
        
    }

    public interface IAtlasEntityDto<TId> : IAtlasEntityDto
    {
        TId Id { get; set; }
    }
}