using JwtPrpject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace JwtPrpject.Entity
{
    public class ApplicationDbContext:DbContext
    {

       
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public DbSet<User>Users { get; set; }
        public DbSet<Role>Roles{ get; set; }

        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Role>().ToTable("Roles");


            for (int i = 0; i < 20; i++)
            {
                modelBuilder.Entity<User>().HasData(new User()

                
                {
                    Id = Guid.NewGuid(),
                    Name = RandomString(4),
                    Email = RandomString(8)+"@gmail.com",
                    Password = RandomString(10),
                }
                    );

            }


            for (int i = 0; i < 4; i++)
            {
                modelBuilder.Entity<Role>().HasData(new Role()


                {
                    Id = Guid.NewGuid(),
                    Name = RandomString(4),
                }
                    );

            }

        }
    }
}
