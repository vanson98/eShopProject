using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<eShopDbContext>
    {
        public eShopDbContext CreateDbContext(string[] args)
        {
            // Khởi tạo đối tượng ConfigurationBuilder từ file appsetting.json
            // Ta phải cài 2 package đó là 
            // Microsoft.Extensions.Configuration.FileExtensions
            // Microsoft.Extensions.Configuration.Json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Lấy connectionString
            var connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<eShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new eShopDbContext(optionsBuilder.Options);
        }
    }
}
