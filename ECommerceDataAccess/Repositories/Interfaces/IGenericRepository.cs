using ECommerceDataModels.Entities.Base;

namespace ECommerceDataAccess.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity, new()
    {
        ICollection<T>? GetAll();
        void Add(T entity);
        void Update(T entity);
        void Save();
        void Remove(int id);
        T? GetById(int id);

    }
}
