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
    public class ComplaintsRepository : IComplaintsRepository
    {
        IDataSource _source;
        public ComplaintsRepository(IDataSource source)
        {
            _source = source;
        }

        public async Task<Complaints> Add(Complaints model)
        {
            _source.Complaints.Add(model);
            await _source.SaveChanges();
            return model;
        }

        public async Task Delete(int key)
        {
            _source.Complaints.Remove(await GetById(key));
            await _source.SaveChanges();
        }

        public async Task<List<Complaints>> GetAll()
        {
            return await _source.Complaints.ToListAsync();
        }

        public async Task<Complaints> GetById(int key)
        {

            return await _source.Complaints.FirstOrDefaultAsync(k => k.ComplaintId == key);
        }

        public async Task<Complaints> Update(Complaints model)
        {
            var update = _source.Complaints.Update(model).Entity;
            await _source.SaveChanges();
            return update;
        }
    }
}
