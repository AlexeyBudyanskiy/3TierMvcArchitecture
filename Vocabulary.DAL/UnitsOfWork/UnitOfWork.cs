using System;
using Vocabulary.DAL.EF;
using Vocabulary.DAL.Entities;
using Vocabulary.DAL.Interfaces;
using Vocabulary.DAL.Repositories;

namespace Vocabulary.DAL.UnitsOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;
        private IRepository<Example> _exampleRepository;

        private bool _disposed;

        public UnitOfWork(string databaseConnectionString)
        {
            _databaseContext = new DatabaseContext(databaseConnectionString);
        }

        public IRepository<Example> Examples => _exampleRepository ?? (_exampleRepository = new CommonRepository<Example>(_databaseContext));

        public void Save()
        {
            _databaseContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _databaseContext.Dispose();
            }

            _disposed = true;
        }
    }
}
