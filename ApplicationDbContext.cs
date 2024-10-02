using System;
using Microsoft.EntityFrameworkCore;
using SampleSecuredWeb.Models;

namespace SampleSecuredWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set; } = null!;
    }
}