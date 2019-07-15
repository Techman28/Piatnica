using BusinessToBusiness.Dal.Entities;
using ITMCode.Piatnica.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessToBusiness.Dal.Repositories
{
    public interface IBaseRepository<TObject> where TObject : class, IEntity
    {
        Task<bool> AnyAsync(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null);
        TObject Add(TObject t);
        Task<TObject> AddAsync(TObject t);
        IEnumerable<TObject> AddRange(IEnumerable<TObject> t);
        Task<IEnumerable<TObject>> AddRangeAsync(IEnumerable<TObject> t);
        int Count();
        Task<int> CountAsync();
        void Delete(TObject t);
        Task DeleteAsync(TObject t);
        void DeleteRange(IEnumerable<TObject> t);
        Task DeleteRangeAsync(IEnumerable<TObject> t);
        TObject Find(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null);
        TObject Find(int id, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null);
        TObject FindDefault(int id, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null);
        IEnumerable<TObject> FindAll(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null, int? skip = null, int? take = null);
        Task<IEnumerable<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null, int? skip = null, int? take = null);
        Task<TObject> FindAsync(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null);
        Task<TObject> FindAsyncDefault(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null);
        Task<TObject> FindAsync(int id, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null);
        Task<TObject> FindAsyncDefault(int id, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null);
        IEnumerable<TObject> GetAll(Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null, int? skip = null, int? take = null);
        Task<IEnumerable<TObject>> GetAllAsync(Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null, int? skip = null, int? take = null);
        TObject Update(TObject t);
        Task<TObject> UpdateAsync(TObject t);
        IEnumerable<TObject> UpdateRange(IEnumerable<TObject> t);
        Task<IEnumerable<TObject>> UpdateRangeAsync(IEnumerable<TObject> t);
    }
}
