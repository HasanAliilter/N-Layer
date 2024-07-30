using System.Linq.Expressions;

namespace N_Layer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func< T, bool>> predicate); //IQueryable sayesinde mesela bir orderby yaptığımız zaman direkt olarak vt yerine memory üzerinden alınabiliyor bu nedenle vt yükünü azaltabiliyoruz
        //IQuryable IEnumerable yerine benim koşullarımı sağlayan verileri benim memory ye getiriyor
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
