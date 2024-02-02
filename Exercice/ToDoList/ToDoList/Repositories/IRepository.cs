using System.Linq.Expressions;

namespace ToDoList.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        bool Add(TEntity entity);
        bool Delete(int id);
        bool Update(TEntity entity);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity? GetById(int id);
    }
}
