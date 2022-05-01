using System.Linq.Expressions;

namespace LibraryManage.Contract.IServices
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindAllCondition(Expression<Func<T , bool>> expression , bool trackchanges);
        void Create(T entity); 
        void Update(T entity);
        void Delete(T entity);

    }
}
