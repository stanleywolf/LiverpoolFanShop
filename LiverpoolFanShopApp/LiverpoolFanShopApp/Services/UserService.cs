using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiverpoolFanShopApp.Data;
using LiverpoolFanShopApp.Services.Contracts;

namespace LiverpoolFanShopApp.Services
{
    public class UserService: IUserService
    {
        private readonly ApplicationDbContext db;

        public UserService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int CountUsers()
        {
            return this.db.Users.Count();
        }
    }
}
