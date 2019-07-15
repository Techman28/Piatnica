using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal;
using Microsoft.EntityFrameworkCore;

namespace ITMCode.Piatnica.Dal.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly PiatnicaContext _context;
        DbSet<T> _dbSet;
        public GenericRepository() { }
        public GenericRepository(PiatnicaContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(Int32 recordID)
        {
            return _dbSet.Find( recordID);
        }
        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(Int32 recordID)
        {
            T entity = _dbSet.Find(recordID);
            _dbSet.Remove(entity);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}