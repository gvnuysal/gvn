using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Gvn.Atlas.Domain.Entities;
using JetBrains.Annotations;

namespace Gvn.Atlas.Domain.Repositories;

public interface IAtlasReadOnlyBasicRepository<TEntity> : IAtlasRepository where TEntity : class, IAtlasEntity
{
    /// <summary>
    /// Veritabanındaki toplam kayıt sayısını dönecek
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<long> GetCountAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Veritabanından gelen veriler sayfalama alt yapısı ile gelecek aayrıca sıralama ve master detail ilişkiside olack
    /// </summary>
    /// <param name="skip">Skip</param>
    /// <param name="take">Take</param>
    /// <param name="sortingBy">Sıralama Key i</param>
    /// <param name="includeDetails">Detay tablo ilişkisi</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<TEntity>> GetPagedListAsync(int skip, int take, string sortingBy, bool includeDetails,
        CancellationToken cancellationToken = default);
    Task<List<TEntity>> GetListAsync(bool includeDetails, CancellationToken cancellationToken = default);
}

public interface IAtlasReadOnlyBasicRepository<TEntity, TKey> : IAtlasReadOnlyBasicRepository<TEntity>
    where TEntity : class, IAtlasEntity<TKey>
{
    [JetBrains.Annotations.NotNull]
    Task<TEntity> GetAsync(TKey id,bool includes, CancellationToken cancellationToken = default);
    Task<TEntity?> FindAsync(TKey id,bool includes, CancellationToken cancellationToken = default);
}