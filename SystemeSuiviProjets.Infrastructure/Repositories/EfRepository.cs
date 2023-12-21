using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemeSuiviProjets.Infrastructure.Specifications;
using SystemeSuiviProjets.SharedKernel;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Infrastructure.Repositories 
{
    public class EfRepository<T> : IAsyncRepository<T>, IRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly SystèmeSuiviProjetsContext _SystemeSuiviProjetsContext;

        public EfRepository(SystèmeSuiviProjetsContext systemeSuiviProjetsContext)
        {
            _SystemeSuiviProjetsContext = systemeSuiviProjetsContext;
        }

        public T Add(T entity)
        {
            _SystemeSuiviProjetsContext.Set<T>().Add(entity);
            _SystemeSuiviProjetsContext.SaveChanges();
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _SystemeSuiviProjetsContext.Set<T>().AddAsync(entity);
            await _SystemeSuiviProjetsContext.SaveChangesAsync();
            return entity;
        }

        public int Count(ISpecification<T> spec)
        {
            return ApplySpecification(spec).Count();
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public int Delete(T entity)
        {
            _SystemeSuiviProjetsContext.Set<T>().Remove(entity);
            return _SystemeSuiviProjetsContext.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            _SystemeSuiviProjetsContext.Set<T>().Remove(entity);
            await _SystemeSuiviProjetsContext.SaveChangesAsync();
        }

        public bool EntityExists(int id)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return _SystemeSuiviProjetsContext.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await
            _SystemeSuiviProjetsContext.Set<T>().FindAsync(id);
        }

        public IReadOnlyList<T> List(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<T> ListAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await
            _SystemeSuiviProjetsContext.Set<T>().ToListAsync();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            _SystemeSuiviProjetsContext.Entry(entity).State = EntityState.Modified;
            await _SystemeSuiviProjetsContext.SaveChangesAsync();
        }

        void IAsyncRepository<T>.UpdateAsync(T entity)
        {
            _ = UpdateAsync(entity);
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return
            SpecificationEvaluator<T>.GetQuery(
            _SystemeSuiviProjetsContext.Set<T>().AsQueryable(), spec);
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }
    }


}
