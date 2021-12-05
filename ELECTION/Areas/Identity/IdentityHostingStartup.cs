using System;
using ELECTION.Areas.Identity.Data;
using ELECTION.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ELECTION.Areas.Identity.IdentityHostingStartup))]
namespace ELECTION.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ELECTIONContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ELECTIONContextConnection")));


                services.AddDefaultIdentity<ELECTIONUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<ELECTIONContext>();
            });
        }
    }
}