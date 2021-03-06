﻿using System;
using System.Data.Entity;
using System.Linq;
using Vocabulary.DAL.EF;
using Vocabulary.DAL.Entities;
using Vocabulary.DAL.Interfaces;

namespace Vocabulary.DAL.Repositories
{
    public class CommonRepository<TEntity> : IRepository<TEntity> where TEntity : BaseType
    {
        private readonly DatabaseContext _db;

        public CommonRepository(DatabaseContext db)
        {
            _db = db;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _db.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _db.Set<TEntity>().Where(predicate).AsQueryable();
        }

        public virtual void Create(TEntity item)
        {
            _db.Set<TEntity>().Add(item);
        }

        public virtual void Update(TEntity item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public virtual void Delete(int id)
        {
            var item = Get(id);
            _db.Set<TEntity>().Remove(item);
        }
    }
}
