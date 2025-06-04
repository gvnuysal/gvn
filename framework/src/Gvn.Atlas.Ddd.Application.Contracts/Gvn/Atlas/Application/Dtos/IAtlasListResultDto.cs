using System.Collections.Generic;

namespace Gvn.Atlas.Application.Dtos;

public interface IAtlasListResultDto<T>
{
    /// <summary>
    /// Veritabanından çektiğimiz verileri tutacak.
    /// </summary>
    IReadOnlyList<T> Items { get; set; }
}