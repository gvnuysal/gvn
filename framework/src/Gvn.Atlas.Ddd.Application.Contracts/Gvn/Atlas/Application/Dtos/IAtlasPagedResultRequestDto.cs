namespace Gvn.Atlas.Application.Dtos;

public interface IAtlasPagedResultRequestDto:IAtlasLimitedResultRequestDto
{
    /// <summary>
    /// Başlangıç sayfa sayısını verir
    /// </summary>
    int Skip { get; set; }
}