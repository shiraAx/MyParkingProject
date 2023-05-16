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
    public class PurchasePointsService : IPurchasePointsService
    {
        readonly IPurchasePointsRepository rep;
        readonly IMapper mapper;
        public PurchasePointsService(IPurchasePointsRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<PurchasePointsModel> Add(PurchasePointsModel model)
        {
            return mapper.Map<PurchasePointsModel>(await rep.Add(mapper.Map<PurchasePoints>(model)));

        }

        public async Task Delete(int key)
        {
            await rep.Delete(key);

        }

        public async Task<List<PurchasePointsModel>> GetAll()
        {
            return mapper.Map<List<PurchasePointsModel>>(await rep.GetAll());

        }

        public async Task<PurchasePointsModel> GetById(int key)
        {
            return mapper.Map<PurchasePointsModel>(await rep.GetById(key));

        }

        public async Task<PurchasePointsModel> Update(PurchasePointsModel model)
        {
            return mapper.Map<PurchasePointsModel>(await rep.Update(mapper.Map<PurchasePoints>(model)));

        }
    }
}
