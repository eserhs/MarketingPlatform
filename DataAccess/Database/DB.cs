using Core.Entities.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;

using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DataAccess.Database
{
    public class DB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-C3PQ256\MSSQLSERVER1;Database=MyProjet;Trusted_Connection=true");

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Productss { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<PackageFeature> PackageFeatures{ get; set; }
        public DbSet<PackageLevel> PackageLevels { get; set; }
        public DbSet<Feature> Features { get; set; }


    }
}

