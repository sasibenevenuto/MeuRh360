using Dapper;
using Domain.General;
using Microsoft.Extensions.Options;
using Npgsql;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : ModelBase
    {
        private readonly IDbConnection _connection;
        public Repository(IOptions<AppSettings> options)
        {
            _connection = new NpgsqlConnection(options.Value.ConnectionStrings.MeuRh360);
        }

        public async Task Add(string query, TEntity entity)
        {
            await _connection.ExecuteAsync(query, entity);
        }

        public async Task Delete(string query)
        {
            await _connection.ExecuteAsync(query);
        }

        public async Task<IEnumerable<TEntity>> GetAll(string query)
        {
            return await _connection.QueryAsync<TEntity>(query);
        }

        public async Task<TEntity> GetOne(string query, TEntity entity)
        {
            return await _connection.QueryFirstAsync<TEntity>(query, entity);
        }

        public async Task<TEntity> Update(string query, TEntity entity)
        {
            await _connection.ExecuteAsync(query, entity);

            return entity;
        }
    }
}
