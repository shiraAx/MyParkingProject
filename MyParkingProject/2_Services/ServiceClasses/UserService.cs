using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repositories.Entities;
using _3_Repositories.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.ServiceClasses
{
    public class UserService : IUserService
    {
        readonly IUserRepository rep;
        readonly IMapper mapper;
        public UserService(IUserRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<UserModel> Add(UserModel model)
        {
            return mapper.Map<UserModel>(await rep.Add(mapper.Map<User>(model)));
        }

        public async Task Delete(int key)
        {
            await rep.Delete(key);

        }

        public async Task<List<UserModel>> GetAll()
        {
            return mapper.Map<List<UserModel>>(await rep.GetAll());

        }

        public async Task<UserModel> GetById(int key)
        {
            return mapper.Map<UserModel>(await rep.GetById(key));

        }

        public async Task<UserModel> Update(UserModel model)
        {
            return mapper.Map<UserModel>(await rep.Update(mapper.Map<User>(model)));

        }
    }
}
