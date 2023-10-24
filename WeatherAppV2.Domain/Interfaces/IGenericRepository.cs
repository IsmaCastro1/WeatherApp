using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppV2.Domain.Interfaces;

    public interface IGenericRepository<T> where T : class
    {
        Task<bool> insert(T entity);
        Task<bool> insertAll(IEnumerable<T> entities);
        Task<bool> update(T entity);
        Task<bool> delete(T entity);
        Task<bool> deleteAll();
        Task<bool> updateAll();
        Task<IQueryable<T>> GetAll();
        Task<T> GetOne(String id);
    }

