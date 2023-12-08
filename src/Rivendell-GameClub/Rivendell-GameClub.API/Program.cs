
using Microsoft.EntityFrameworkCore;
using Rivendell_GameClub.Application.Services.ComputersService;
using Rivendell_GameClub.Application.Services.UsersService;
using Rivendell_GameClub.Infrastructure.DataAccess;
using Rivendell_GameClub.Infrastructure.Repositories.ComputersRepository;
using Rivendell_GameClub.Infrastructure.Repositories.UsersRepository;

namespace Rivendell_GameClub.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
             //Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<RivendellDB>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), providerOptions => providerOptions.EnableRetryOnFailure()));

            //////builder.Services.AddScoped<IComputerService, ComputerService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IComputerService, ComputerService>();
            builder.Services.AddScoped<IComputerRepository, ComputerRepository>();
            
            


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
