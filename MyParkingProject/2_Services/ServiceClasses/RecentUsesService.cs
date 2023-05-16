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
    public class RecentUsesService : IRecentUsesService
    {
        readonly IRecentUsesRepository rep;
        readonly IMapper mapper;
        public RecentUsesService(IRecentUsesRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<RecentUsesModel> Add(RecentUsesModel model)
        {
            return mapper.Map<RecentUsesModel>(await rep.Add(mapper.Map<RecentUses>(model)));

        }

        public async Task Delete(int key)
        {
            await rep.Delete(key);
        }

        public async Task<List<RecentUsesModel>> GetAll()
        {
            return mapper.Map<List<RecentUsesModel>>(await rep.GetAll());

        }

        public async Task<RecentUsesModel> GetById(int key)
        {
            return mapper.Map<RecentUsesModel>(await rep.GetById(key));

        }

        public async Task<RecentUsesModel> Update(RecentUsesModel model)
        {
            return mapper.Map<RecentUsesModel>(await rep.Update(mapper.Map<RecentUses>(model)));

        }
    }
}
