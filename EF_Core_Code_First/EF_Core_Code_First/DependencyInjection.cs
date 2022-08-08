using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Code_First
{
    public static class DependencyInjection
    {

        public static void InjectServicesAndDbConnection(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<DB_Context>(option =>
            option.UseSqlServer("Data Source=NAYEM-AD\\NAYEM;Initial Catalog=Hospitals;User ID=sa;Password=123456"));


        }
    }
}