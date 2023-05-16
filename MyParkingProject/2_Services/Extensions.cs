using _3_Repositories.Interfaces;
using _3_Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Repositories.Repositories;
using _3_Repositories.Entities;
using _2_Services.Models;

namespace _2_Services
{
    public static class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IComplaintsRepository, ComplaintsRepository>();
            services.AddScoped<IParkRepository, ParkRepository>();
            services.AddScoped<IPurchasePointsRepository, PurchasePointsRepository>();
            services.AddScoped<IRecentUsesRepository, RecentUsesRepository>();
            services.AddScoped<ISharedParkingRepository, SharedParkingRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IVehicleDetailsRepository, VehicleDetailsRepository > ();



            MapperConfiguration config = new MapperConfiguration(a =>
            {
                a.CreateMap<Complaints, ComplaintsModel>().ReverseMap();
                a.CreateMap<Park, ParkModel>().ReverseMap();
                a.CreateMap<PurchasePoints, PurchasePointsModel>().ReverseMap();
                a.CreateMap<RecentUses, RecentUsesModel>().ReverseMap();
                a.CreateMap<SharedParking, SharedParkingModel>().ReverseMap();
                a.CreateMap<User, UserModel>().ReverseMap();
                a.CreateMap<VehicleDetails, VehicleDetailsModel>().ReverseMap();
            });


            IMapper Mapper = config.CreateMapper();

            services.AddSingleton(Mapper);



            services.AddDbContext<IDataSource, SQLDataSource>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
    }
}
