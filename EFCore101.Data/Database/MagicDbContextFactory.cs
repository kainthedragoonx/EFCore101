using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace EFCore101.Data.Database
{
    public class MagicDbContextFactory:IDesignTimeDbContextFactory<MagicDbContext>
    {
        public MagicDbContext CreateDbContext(string[] args)
        {
            var connString =
                @"Server=(LocalDb)\MSSQLLocalDB;Database=EFCore101;Integrated Security=SSPI;";
            var optionsBuilder = new DbContextOptionsBuilder<MagicDbContext>();
            optionsBuilder.UseSqlServer(connString,options => options.EnableRetryOnFailure())
                .ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
            // Page 1266 
            return new MagicDbContext(optionsBuilder.Options);
        }
    }
}
