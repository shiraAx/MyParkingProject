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
    public class UserRepository : IUserRepository
    {
        IDataSource _source;
        public UserRepository(IDataSource source)
        {
            _source = source;
        }
        public async Task<User> Add(User model)
        {
            _source.Users.Add(model);
            await _source.SaveChanges();
            return model;
        }

        public async Task Delete(int key)
        {
            _source.Users.Remove(await GetById(key));
            await _source.SaveChanges();
        }

        public async Task<List<User>> GetAll()
        {
            return await _source.Users.ToListAsync();
        }

        public async Task<User> GetById(int key)
        {
            return await _source.Users.FirstOrDefaultAsync(k => k.UserId == key);
        }

        public async Task<User> Update(User model)
        {
            var update = _source.Users.Update(model).Entity;
            await _source.SaveChanges();
            return update;
        }
    }
}
