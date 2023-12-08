
using General_Motors.Application.Services.BuyersService;
using General_Motors.Application.Services.CarsService;
using General_Motors.Infrastructure.DataAccess;
using General_Motors.Infrastructure.Repositories.BuyersRepository;
using General_Motors.Infrastructure.Repositories.CarsRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace General_Motors.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<GMDB>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),providerOptions => providerOptions.EnableRetryOnFailure()));

            builder.Services.AddScoped<IBuyerService, BuyerService>();
            builder.Services.AddScoped<ICarService, CarService>();
            builder.Services.AddScoped<IBuyerRepository, BuyerRepository>();
            builder.Services.AddScoped<ICarRepository, CarRepository>();

/*            builder.Services.AddAuthentication("Bearer")
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateAudience = true,
                        ValidAudience = "Nikita",
                        ValidateIssuer = true,
                        ValidIssuer = "Nikita",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("NurmuhammadSharobiddinovMuzaffarovichNikitaConsolidated")),
                        ValidateIssuerSigningKey = true
                    };
                });*/

            var app = builder.Build();

            // Configure the HTTP request pipeline.
                app.UseSwagger();
                app.UseSwaggerUI();
            

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
