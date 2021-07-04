using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OData.Demo.Data
{
    public class DbSeed
    {
        private readonly AppDbContext _dbContext;

        public DbSeed(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.Migrate();
        }

        public void SeedDb()
        {
            var roles = new List<Role>
            {
                new Role { Id = "3766ff20-be4e-4811-855b-14ea76223972", Name = "Administrator" },
                new Role { Id = "e39de259-42e3-4242-bfad-2004f946693b", Name = "User" },
            };

            if (!_dbContext.Roles.Any())
            {
                _dbContext.Roles.AddRange(roles);
                _dbContext.SaveChanges();
            }

            if (!_dbContext.Accounts.Any())
            {
                var rd = new Random();
                for (var i = 0; i < 20; i++)
                {
                    _dbContext.Accounts.Add(new Account
                    {
                        FirstName = $"First name {i}",
                        LastName = $"Last name {i}",
                        Age = rd.Next(10, 60),
                        Sex = (Sex)rd.Next(0, 1),
                        RoleId = i % 2 == 0 ? "3766ff20-be4e-4811-855b-14ea76223972" : "e39de259-42e3-4242-bfad-2004f946693b"
                    });
                }

                _dbContext.SaveChanges();
            }
        }
    }
}
