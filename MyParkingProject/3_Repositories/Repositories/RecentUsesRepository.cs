using _3_Repositories.Entities;
using _3_Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Repositories
{
    public class RecentUsesRepository : IRecentUsesRepository
    {
        IDataSource _source;
        public RecentUsesRepository(IDataSource source)
        {
            _source = source;
        }
        public async Task<RecentUses> Add(RecentUses model)
        {
            _source.RecentUses.Add(model);
            await _source.SaveChanges();
            return model;
        }

        public async Task Delete(int key)
        {
            _source.RecentUses.Remove(await GetById(key));
            await _source.SaveChanges();
        }

        public async Task<List<RecentUses>> GetAll()
        {
            return await _source.RecentUses.ToListAsync();
        }

        public async Task<RecentUses> GetById(int key)
        {
            return await _source.RecentUses.FirstOrDefaultAsync(k => k.Id == key);
        }

        public async Task<RecentUses> Update(RecentUses model)
        {
            var update = _source.RecentUses.Update(model).Entity;
            await _source.SaveChanges();
            return update;
        }
    }
}
