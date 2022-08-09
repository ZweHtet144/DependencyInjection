using DependencyInjectionWithDBService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWithDBService.Services.DBContext
{
    public class EFDBContext:DbContext
    {
        public EFDBContext(DbContextOptions options) : base(options) { }
        public DbSet<StudentModel> Students { get; set; }
    }
}
