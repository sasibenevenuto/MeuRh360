using Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : ModelBase
    {
        Task Add(string query, TEntity entity);
        Task<TEntity> Update(string query, TEntity entity);
        Task Delete(string query);
        Task<TEntity> GetOne(string query, TEntity entity);
        Task<IEnumerable<TEntity>> GetAll(string query);

    }
}
