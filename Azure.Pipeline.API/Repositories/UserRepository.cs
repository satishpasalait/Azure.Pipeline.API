using Azure.Pipeline.API.Models;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System;

namespace Azure.Pipeline.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetUsers()
        {
            return new List<User>()
            {
                new User { Id = 1, Name = "Steve Smith", ADName = "ssmith", Department = "Technology", Role = "Admin", Status = "Active", CreatedOn = DateTime.Now.AddDays(-299) },
                new User { Id = 2, Name = "Travis Head", ADName = "thead", Department = "Billing", Role = "Admin", Status = "Active", CreatedOn = DateTime.Now.AddDays(-299) },
                new User { Id = 3, Name = "Tim David", ADName = "tdavid", Department = "Technology", Role = "Developer", Status = "Active", CreatedOn = DateTime.Now.AddDays(-299) },
                new User { Id = 4, Name = "Erin Gerlach", ADName = "egerlach", Department = "Billing", Role = "Admin", Status = "Active", CreatedOn = DateTime.Now.AddDays(-299) },
                new User { Id = 5, Name = "Pat Smith", ADName = "psmith", Department = "Technology", Role = "DBA", Status = "Active", CreatedOn = DateTime.Now.AddDays(-299) },
                new User { Id = 6, Name = "David Schinner", ADName = "dschinner", Department = "Technology", Role = "Cloud", Status = "Active", CreatedOn = DateTime.Now.AddDays(-299) },
            };
        }
    }
}
