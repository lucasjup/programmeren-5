using System;
using Awen.Areas.Identity.Data;
using Awen.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Awen.Areas.Identity.IdentityHostingStartup))]
namespace Awen.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<AwenContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("AwenContextConnection")));

                //services.AddDefaultIdentity<AwenUser>()
                //    .AddEntityFrameworkStores<AwenContext>();
            });
        }
    }
}