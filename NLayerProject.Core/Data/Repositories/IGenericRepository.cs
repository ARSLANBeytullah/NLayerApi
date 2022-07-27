using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Data.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T,bool>> expression); //example call:ProductRepository.Where(x=>x.id>5).OrderBy.ToListAsync();
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);
        
        void Update(T entity); //Güncelleme ve silmenin asenkronu yok. Bunlar zaten çok performanslı durumlar olduğundan asenkronları yoktur.
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}