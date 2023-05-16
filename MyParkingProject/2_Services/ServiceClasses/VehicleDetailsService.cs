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
    public class VehicleDetailsService : IVehicleDetailsService
    {
        readonly IVehicleDetailsRepository rep;
        readonly IMapper mapper;
        public VehicleDetailsService(IVehicleDetailsRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<VehicleDetailsModel> Add(VehicleDetailsModel model)
        {
            return mapper.Map<VehicleDetailsModel>(await rep.Add(mapper.Map<VehicleDetails>(model)));

        }

        public async Task Delete(int key)
        {
            await rep.Delete(key);
        }

        public async Task<List<VehicleDetailsModel>> GetAll()
        {
            return mapper.Map<List<VehicleDetailsModel>>(await rep.GetAll());

        }

        public async Task<VehicleDetailsModel> GetById(int key)
        {
            return mapper.Map<VehicleDetailsModel>(await rep.GetById(key));

        }

        public async Task<VehicleDetailsModel> Update(VehicleDetailsModel model)
        {
            return mapper.Map<VehicleDetailsModel>(await rep.Update(mapper.Map<VehicleDetails>(model)));

        }
    }
}
