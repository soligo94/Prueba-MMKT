using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MMKTBackend.API;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.OpenApi.Models;
using MMKTBackend.Infrastructure.ProductContext;
using MMKTBackend.Application.IProductServices;
using MMKTBackend.Application.Services;
using MMKTBackend.Infrastructure.Repositories;
using MMKTBackend.Domain.Interfaces;

namespace MMKTBackend
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
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Productos MMKT API", Description="API para insertar productos (post (//API//productos)) y ver la cantidad de productos a?adidos a la base de datos (get (//API//nuevoProducto))", Version = "v1" });
            });

            services.AddCors(options =>
            {
                var frontendURL = Configuration.GetValue<string>("frontend_url");
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins(frontendURL).AllowAnyMethod().AllowAnyHeader().WithExposedHeaders(new string[] { "totalRecords" });
                });
            });
            services.AddDbContext<ProductDbContext>(options
            => options.UseSqlServer(Configuration.GetConnectionString("defaultConnection"), b => b.MigrationsAssembly("MMKTBackend.API")));
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MMKTBackend v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(Configuration.GetValue<string>("frontend_url"));

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
