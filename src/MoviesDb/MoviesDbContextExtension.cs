using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesCore
{
    public static class MoviesDbContextExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ADMIN_ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = USER_ROLE_ID,
                    Name = "User",
                    NormalizedName = "USER"
                });

            string ADMIN_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();

            var admin = new User
            {
                Id = ADMIN_ID,
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                NormalizedEmail = "admin@gmail.com".ToUpper(),
                NormalizedUserName = "admin@gmail.com".ToUpper()
            };
            var user = new User
            {
                Id = USER_ID,
                UserName = "user@gmail.com",
                Email = "user@gmail.com",
                EmailConfirmed = true,
                NormalizedEmail = "user@gmail.com".ToUpper(),
                NormalizedUserName = "user@gmail.com".ToUpper()
            };

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            admin.PasswordHash = hasher.HashPassword(admin, "admin$Pass1");
            user.PasswordHash = hasher.HashPassword(user, "user$Pass1");

            builder.Entity<User>().HasData(admin, user);


            builder.Entity<IdentityUserRole<string>>().HasData(
             new IdentityUserRole<string>
             {
                 RoleId = ADMIN_ROLE_ID,
                 UserId = ADMIN_ID
             },
             new IdentityUserRole<string>
             {
                 RoleId = USER_ROLE_ID,
                 UserId = ADMIN_ID
             },
             new IdentityUserRole<string>
             {
                 RoleId = USER_ROLE_ID,
                 UserId = USER_ID
             });




            builder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    GenreName = "Action"
                },
                new Genre
                {
                    Id = 2,
                    GenreName = "Fantasy"
                },
                new Genre
                {
                    Id = 3,
                    GenreName = "Detective"
                });
               

            builder.Entity<Director>().HasData(
                new Director
                {
                    Id = 1,
                    FirstName = "Christopher",
                    LastName = "Nolan"
                },
                new Director
                {
                    Id = 2,
                    FirstName = "Peter",
                    LastName = "Jackson"
                }
                );

           

            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Interstellar",
                    Description = "Some random text",
                    PosterPath = "https://static.posters.cz/image/750/%D0%9F%D0%BB%D0%B0%D0%BA%D0%B0%D1%82%D0%B8/interstellar-ice-walk-i23290.jpg",
                    Rating = 9.27f,
                    ReleaseYear = 2014,
                    Duration = 130,
                }
                );
        }
    }
}


