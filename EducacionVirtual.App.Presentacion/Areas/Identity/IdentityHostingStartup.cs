using System;
using EducacionVirtual.App.Presentacion.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EducacionVirtual.App.Presentacion.Areas.Identity.IdentityHostingStartup))]
namespace EducacionVirtual.App.Presentacion.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityDataContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityDataContextConnection")));

                services.AddDefaultIdentity<Usuario>(options => options.SignIn.RequireConfirmedAccount = true)
        
                    .AddEntityFrameworkStores<IdentityDataContext>();
            });
        }
    }
}