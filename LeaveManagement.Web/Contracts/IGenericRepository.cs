﻿namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);

        Task AddRangeAsync(List<T> entities);
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int? id);
        //Task<T> GetCountAsync(int id);
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);

    }
}
