using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_DAW.Models;

namespace Proiect_DAW.data
{
    public class Proiect_DAWContext : DbContext
    {
        public Proiect_DAWContext (DbContextOptions<Proiect_DAWContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_DAW.Models.Recipe> Recipe { get; set; }
        public DbSet<Proiect_DAW.Models.User> User { get; set; }
        public DbSet<Proiect_DAW.Models.Role> Role { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserRole>()
                .HasOne(x => x.User)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.UserId);

            builder.Entity<UserRole>()
                .HasOne(x => x.Role)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.RoleId);

            builder.Entity<UserRole>()
                .HasAlternateKey(x => new { x.UserId, x.RoleId });


            builder.Entity<Recipe>()
                .HasOne(x => x.User)
                .WithMany(y => y.Recipes)
                .HasForeignKey(z => z.UserId);


        }
    }
}
