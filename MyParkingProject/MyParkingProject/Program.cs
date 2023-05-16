using _2_Services;
using _2_Services.Interfaces;
using _2_Services.ServiceClasses;

namespace MyParkingProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins, builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IComplaintsService, ComplaintsService>();
            builder.Services.AddScoped<IParkService, ParkService>();
            builder.Services.AddScoped<IPurchasePointsService, PurchasePointsService>();
            builder.Services.AddScoped<IRecentUsesService, RecentUsesService>();
            builder.Services.AddScoped<ISharedParkingService, SharedParkingService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IVehicleDetailsService, VehicleDetailsService>();
            builder.Services.AddRepoDependencies();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}