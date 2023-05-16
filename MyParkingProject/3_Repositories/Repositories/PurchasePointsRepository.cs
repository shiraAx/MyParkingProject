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
    public class PurchasePointsRepository : IPurchasePointsRepository
    {
        IDataSource _source;
        public PurchasePointsRepository(IDataSource source)
        {
            _source = source;
        }
        public async Task<PurchasePoints> Add(PurchasePoints model)
        {
            _source.PurchasePoints.Add(model);
            await _source.SaveChanges();
            return model;
        }

        public async Task Delete(int key)
        {
            _source.PurchasePoints.Remove(await GetById(key));
            await _source.SaveChanges();
        }

        public async Task<List<PurchasePoints>> GetAll()
        {
            return await _source.PurchasePoints.ToListAsync();
        }

        public async Task<PurchasePoints> GetById(int key)
        {
            return await _source.PurchasePoints.FirstOrDefaultAsync(k => k.PurchasePointId == key);
        }

        public async Task<PurchasePoints> Update(PurchasePoints model)
        {
            var update = _source.PurchasePoints.Update(model).Entity;
            await _source.SaveChanges();
            return update;
        }
    }
}
