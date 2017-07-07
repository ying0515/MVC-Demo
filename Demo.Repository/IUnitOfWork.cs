﻿using System;

namespace Demo.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TRepository> GetRepository<TRepository>() where TRepository : class;
        void ExecuteProcedure(string procedureCommand, params object[] sqlParams);
        void SaveChanges();
    }
}