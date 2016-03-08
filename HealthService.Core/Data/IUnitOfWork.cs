﻿using HealthService.Core.Data.Repositories;
using HealthService.Core.Entities.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Core.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

        void BeginTransaction();

        int Commit();

        Task<int> CommitAsync();

        void Rollback();

        void Dispose(bool disposing);
    }
}