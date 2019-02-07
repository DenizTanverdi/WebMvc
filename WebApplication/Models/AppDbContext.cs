using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("StuCon")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>("StuConn"));
        }
    }
}