using ECommerceDataAccess.Context;
using ECommerceDataAccess.Repositories.Interfaces;
using ECommerceDataModels.Entities.Base;

namespace ECommerceDataAccess.Repositories
{
    public class GenericRepo<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        internal readonly E_commerceDb? _context;
        public GenericRepo() { 
            _context = new E_commerceDb();
        }
        public void Add(T entity)
        {
            if (entity is null) throw new Exception();
            _context?.Set<T>().Add(entity);
        }

        public ICollection<T>? GetAll()
        {
            return _context?.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            if (id <= 0) throw new Exception();
            var entity = _context?.Set<T>().FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public void Remove(int id)
        {
            if (id <= 0) throw new Exception();
            var entity = _context?.Set<T>().FirstOrDefault(x => x.Id == id);

            if (entity is null) throw new Exception();
            _context?.Set<T>().Remove(entity);
        }

        public void Save()
        {
            _context?.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity is null) throw new Exception();
            _context?.Set<T>().Update(entity);
        }
    }
}
