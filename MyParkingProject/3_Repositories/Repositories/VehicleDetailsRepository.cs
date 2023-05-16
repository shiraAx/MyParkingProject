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
    public class VehicleDetailsRepository : IVehicleDetailsRepository
    {
        IDataSource _source;
        public VehicleDetailsRepository(IDataSource source)
        {
            _source = source;
        }
        public async Task<VehicleDetails> Add(VehicleDetails model)
        {
            _source.VehiclesDetails.Add(model);
            await _source.SaveChanges();
            return model;
        }

        public async Task Delete(int key)
        {
            _source.VehiclesDetails.Remove(await GetById(key));
            await _source.SaveChanges();
        }

        public async Task<List<VehicleDetails>> GetAll()
        {
            return await _source.VehiclesDetails.ToListAsync();
        }

        public async Task<VehicleDetails> GetById(int key)
        {
            return await _source.VehiclesDetails.FirstOrDefaultAsync(k => k.Id == key);
        }

        public async Task<VehicleDetails> Update(VehicleDetails model)
        {
            var update = _source.VehiclesDetails.Update(model).Entity;
            await _source.SaveChanges();
            return update;
        }
    }
}
