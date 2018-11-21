using ChatAppCommandBackend.Context;
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

        public void ConfigureServices(IServiceCollection services){
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<AppDbContext>(option => option.UseSqlite("Data Source=mydb.db"));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env){
            
            app.UseDeveloperExceptionPage();
            app.UseMvc();
        }
    }
}