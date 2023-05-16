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
    public class ParkService:IParkService
    {
      readonly  IParkRepository rep;
        readonly IMapper mapper;
        public ParkService(IParkRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<ParkModel> Add(ParkModel model)
        {
            return mapper.Map<ParkModel>(await rep.Add(mapper.Map<Park>(model)));
        }


        public async Task Delete(int key)
        {
            await rep.Delete(key);
        }

        public async Task<List<ParkModel>> GetAll()
        {
            return mapper.Map<List<ParkModel>>(await rep.GetAll());

        }

        public async Task<ParkModel> GetById(int key)
        {
            return mapper.Map<ParkModel>(await rep.GetById(key));

        }

        public async Task<ParkModel> Update(ParkModel model)
        {
            return mapper.Map<ParkModel>(await rep.Update(mapper.Map<Park>(model)));

        }
    }
}
