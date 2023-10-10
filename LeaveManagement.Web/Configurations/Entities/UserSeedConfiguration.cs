using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                 new Employee
                 {
                     Id = "408aa945-3d84-4421-8342-7269ec64d949",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     UserName = "admin@localhost.com",
                     Firstname = "System",
                     Lastname = "Admin",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4409-b416-ba356312e659",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     Firstname = "System",
                     Lastname = "User",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}











/*using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
               new Employee
               {
                   Id = "ea222b7a-8967-4dd4-b883-7459a607923b",
                   Email="admin1@gmail.com",
                   NormalizedEmail = "ADMIN1@GMAIL.COM",
                   NormalizedUserName= "ADMIN1@GMAIL.COM",
                   UserName= "admin1@gmail.com",
                   Firstname ="System",
                   Lastname="Admin",
                   PasswordHash = hasher.HashPassword(null,"Password@1"),
                   EmailConfirmed=true

               },
                new Employee
                {
                    Id = "e6a8527e-7d97-40e1-8092-4589b809bff0",
                    Email = "user1@gmail.com",
                    NormalizedEmail = "USER1@GMAIL.COM",
                    NormalizedUserName= "USER1@GMAIL.COM",
                    UserName= "user1@gmail.com",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "Password@1"),
                    EmailConfirmed = true

                }
            );
        }
    }
}*/



































