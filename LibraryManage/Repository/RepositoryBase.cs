using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;
using Microsoft.EntityFrameworkCore;

namespace LibraryManage.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T: class
    {
        protected LibraryManageContext _libraryManageContext;
        public RepositoryBase(LibraryManageContext libraryManageContext)
        {
            _libraryManageContext = libraryManageContext;
        }
        public void Create(T entity)
        {
        _libraryManageContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _libraryManageContext.Set<T>().Remove(entity); 
                }

        public IQueryable<T> FindAll(bool trackChanges)
        {
           return  !trackChanges ? _libraryManageContext.Set<T>().AsNoTracking() :
                 _libraryManageContext.Set<T>(); 
        }

        public IQueryable<T> FindAllCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression, bool trackchanges) =>
            !trackchanges ? _libraryManageContext.Set<T>().Where(expression).AsNoTracking() :
            _libraryManageContext.Set<T>().Where(expression); 
        

        public void Update(T entity)
        {
            _libraryManageContext.Set<T>().Update(entity);
        }
    }
}
