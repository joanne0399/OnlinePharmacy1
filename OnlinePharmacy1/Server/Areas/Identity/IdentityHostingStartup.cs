using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlinePharmacy1.Server.Data;
using OnlinePharmacy1.Server.Models;

[assembly: HostingStartup(typeof(OnlinePharmacy1.Server.Areas.Identity.IdentityHostingStartup))]
namespace OnlinePharmacy1.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}