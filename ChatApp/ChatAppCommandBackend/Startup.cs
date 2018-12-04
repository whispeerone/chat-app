using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using ChatAppCommandBackend.Context;
using ChatAppCommandBackend.Strats;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChatAppCommandBackend{
    public class Startup{
        public Startup(IConfiguration configuration){
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public IServiceProvider ConfigureServices(IServiceCollection services){
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<AppDbContext>(option => option.UseSqlite("Data Source=mydb.db"));
            services.AddMediatR();


            var builder = new ContainerBuilder();

            builder.Populate(services);

            builder.RegisterType<StratA>().Named<Strat>("a");
            builder.RegisterType<StratB>().Named<Strat>("b");


            return new AutofacServiceProvider(builder.Build());

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env){

            
            
            
            app.UseDeveloperExceptionPage();
            app.UseMvc();
        }
    }
}