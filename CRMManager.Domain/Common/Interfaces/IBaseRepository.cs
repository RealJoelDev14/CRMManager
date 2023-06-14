using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Domain.Common.Interfaces
{
    public interface IBaseRepository <T,TId> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(TId id);
        Task<T> GetByIdAsync(TId id);
    }
}
