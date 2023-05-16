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
    public class SharedParkingRepository : ISharedParkingRepository
    {
        IDataSource _source;
        public SharedParkingRepository(IDataSource source)
        {
            _source = source;
        }
        public async Task<SharedParking> Add(SharedParking model)
        {
            _source.SharedParkings.Add(model);
            await _source.SaveChanges();
            return model;
        }

        public async Task Delete(int key)
        {
            _source.SharedParkings.Remove(await GetById(key));
            await _source.SaveChanges();
        }

        public async Task<List<SharedParking>> GetAll()
        {
            return await _source.SharedParkings.ToListAsync();
        }

        public async Task<SharedParking> GetById(int key)
        {
            return await _source.SharedParkings.FirstOrDefaultAsync(k => k.SharedParkingId == key);
        }

        public async Task<SharedParking> Update(SharedParking model)
        {
            var update = _source.SharedParkings.Update(model).Entity;
            await _source.SaveChanges();
            return update;
        }
    }
}
