using MongoDB.Driver;

namespace back_piviii.DAL.Model
{
    public interface IMongoContext
    {
        IMongoCollection<Usuario> CollectionUsuario { get; }
        IMongoCollection<Canvas> CollectionCanvas { get; }
    }
}