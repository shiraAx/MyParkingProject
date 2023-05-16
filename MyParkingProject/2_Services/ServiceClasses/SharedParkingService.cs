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
    public class SharedParkingService : ISharedParkingService
    {
        readonly ISharedParkingRepository rep;
        readonly IMapper mapper;
        public async Task<SharedParkingModel> Add(SharedParkingModel model)
        {
            return mapper.Map<SharedParkingModel>(await rep.Add(mapper.Map<SharedParking>(model)));

        }

        public async Task Delete(int key)
        {
            await rep.Delete(key);

        }

        public async Task<List<SharedParkingModel>> GetAll()
        {
            return mapper.Map<List<SharedParkingModel>>(await rep.GetAll());

        }

        public async Task<SharedParkingModel> GetById(int key)
        {
            return mapper.Map<SharedParkingModel>(await rep.GetById(key));

        }

        public  async Task<SharedParkingModel> Update(SharedParkingModel model)
        {
            return mapper.Map<SharedParkingModel>(await rep.Update(mapper.Map<SharedParking>(model)));

        }
    }
}
