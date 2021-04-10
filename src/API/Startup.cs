using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using PVAO.Infrastructure.Data;
using PVAO.ApplicationCore.Interfaces;
using PVAO.ApplicationCore.Entities.Security;
using PVAO.ApplicationCore.Services;

namespace PVAO
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = "http://localhost:55653",
                   ValidAudience = "http://localhost:55653",
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KeyForSignInSecret@1234"))
               };
            });

            services.AddControllers();

            services.AddDbContext<PVAOContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<IVDMSContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("iVDMSConnection")));

            services.Configure<TokenOptions>(Configuration.GetSection("TokenOptions"));

            services.AddScoped(typeof(ISettingsRepository), typeof(SettingsRepository));
            services.AddScoped(typeof(ISettingsService), typeof(SettingsService));
            services.AddScoped(typeof(IBenefitStatusRepository), typeof(BenefitStatusRepository));
            services.AddScoped(typeof(IBenefitStatusService), typeof(BenefitStatusService));
            services.AddScoped(typeof(IVeteransService), typeof(VeteransService));
            services.AddScoped(typeof(IVeteransRepository), typeof(VeteransRepository));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(
                options => options.WithOrigins("localhost:3000").AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader()
            );

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
