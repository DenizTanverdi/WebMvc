using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("StuConn")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>("StuConn"));
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<ClassRoom> Classroom { get; set; }
    }
}