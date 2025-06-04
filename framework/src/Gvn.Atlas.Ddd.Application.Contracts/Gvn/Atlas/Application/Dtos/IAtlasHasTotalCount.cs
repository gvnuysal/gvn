namespace Gvn.Atlas.Application.Dtos;

public interface IAtlasHasTotalCount
{
    /// <summary>
    /// Entity e ait olan toplam kayıt sayısını verecek.
    /// </summary>
    long TotalCount { get; }
}