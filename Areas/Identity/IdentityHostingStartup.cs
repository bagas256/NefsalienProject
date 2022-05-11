using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NefsalienProject.Areas.Identity.Data;
using NefsalienProject.Data;

[assembly: HostingStartup(typeof(NefsalienProject.Areas.Identity.IdentityHostingStartup))]
namespace NefsalienProject.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<NefsalienDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("NefsalienDbContextConnection")));

                services.AddDefaultIdentity<UserAuthentication>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<NefsalienDbContext>();
            });
        }
    }
}