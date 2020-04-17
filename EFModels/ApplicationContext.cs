using EFModels.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFModels
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Introduction> Introductions { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
