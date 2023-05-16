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
    public class ParkRepository : IParkRepository
    {
        IDataSource _source;
        public ParkRepository(IDataSource source)
        {
            _source = source;
        }
        public async Task<Park> Add(Park model)
        {
            _source.Parks.Add(model);
            await _source.SaveChanges();
            return model;
        }

        public async Task Delete(int key)
        {
            _source.Parks.Remove(await GetById(key));
            await _source.SaveChanges();
        }

        public async Task<List<Park>> GetAll()
        {
            return await _source.Parks.ToListAsync();
        }

        public async Task<Park> GetById(int key)
        {
            return await _source.Parks.FirstOrDefaultAsync(k => k.ParkId == key);
        }

        public async Task<Park> Update(Park model)
        {
            var update = _source.Parks.Update(model).Entity;
            await _source.SaveChanges();
            return update;
        }
    }
}
