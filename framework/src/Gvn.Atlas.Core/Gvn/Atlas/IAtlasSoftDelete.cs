namespace Gvn.Atlas;

public interface IAtlasSoftDelete
{
    /// <summary>
    /// Silinecek olan veriyi db de silinmiş olarak işaretler
    /// </summary>
    bool IsDeleted { get;}
}