using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repositories.Entities;
using _3_Repositories.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.ServiceClasses
{
    public class ComplaintsService : IComplaintsService
    {
        readonly IComplaintsRepository rep;
        readonly IMapper mapper;
        public ComplaintsService(IComplaintsRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<ComplaintsModel> Add(ComplaintsModel model)
        {
            return mapper.Map<ComplaintsModel>(await rep.Add(mapper.Map<Complaints>(model)));
        }
      



        public async Task Delete(int key)
        {
            await rep.Delete(key);
        }

        public async Task<List<ComplaintsModel>> GetAll()
        {
            return mapper.Map<List<ComplaintsModel>>(await rep.GetAll());

        }

        public async Task<ComplaintsModel> GetById(int key)
        {
            return mapper.Map<ComplaintsModel>(await rep.GetById(key));
        }

        public async Task<ComplaintsModel> Update(ComplaintsModel model)
        {
            return mapper.Map<ComplaintsModel>(await rep.Update(mapper.Map<Complaints>(model)));
        }
    }
}
