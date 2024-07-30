using System.Linq.Expressions;

namespace N_Layer.Core.Services
{
    public interface IBaseService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> predicate); //IQueryable sayesinde mesela bir orderby yaptığımız zaman direkt olarak vt yerine memory üzerinden alınabiliyor bu nedenle vt yükünü azaltabiliyoruz
        //IQuryable IEnumerable yerine benim koşullarımı sağlayan verileri benim memory ye getiriyor
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
