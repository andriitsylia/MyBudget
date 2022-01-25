using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Interfaces;
using DAL.EF;
using DAL.Repositories;
using DAL.Entities;
using BLL.Interfaces;
using BLL.Services;
using DTO.Expense;
using DTO.ExpenseType;
using DTO.Income;
using DTO.IncomeType;
using Mapper;

namespace MyBudget
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyBudgetContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddControllers();

            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new DataProfile()));
            services.AddSingleton(mapperConfig.CreateMapper());
            
            services.AddSwaggerGen(c =>c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyBudget", Version = "v1" }));

            services.AddScoped<IBudgetRepository<Income>, BudgetRepository<Income>>();
            services.AddScoped<IBudgetRepository<IncomeType>, BudgetRepository<IncomeType>>();
            services.AddScoped<IBudgetRepository<Expense>, BudgetRepository<Expense>>();
            services.AddScoped<IBudgetRepository<ExpenseType>, BudgetRepository<ExpenseType>>();

            services.AddScoped<IBudgetService<IncomeTypeDto>, IncomeTypeService>();
            services.AddScoped<IBudgetService<ExpenseTypeDto>, ExpenseTypeService>();

            services.AddScoped<IByDateService<IncomeDto>, IncomeService>();
            services.AddScoped<IByDateService<ExpenseDto>, ExpenseService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyBudget v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
