using System.Collections.Generic;
using System.Threading.Tasks;


namespace SystemeSuiviProjets.SharedKernel.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        void UpdateAsync(T entity);
        //void UpdateEntity(T entity); // Added for bug "already attached"
        //Task SaveAsync();
        bool EntityExists(int id);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}