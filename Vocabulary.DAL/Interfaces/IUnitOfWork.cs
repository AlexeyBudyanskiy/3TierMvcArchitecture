using System;
using Vocabulary.DAL.Entities;

namespace Vocabulary.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    { 
        IRepository<Example> Examples { get; }
       
        void Save();
    }
}
