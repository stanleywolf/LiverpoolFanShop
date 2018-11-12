using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiverpoolFanShopApp.Data;
using LiverpoolFanShopApp.Services.Contracts;

namespace LiverpoolFanShopApp.Services
{
    public class DataService:IDataService
    {
        private readonly ApplicationDbContext dbContext;

        public DataService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            
        }

        public void GetAllOrders()
        {
            throw new NotImplementedException();
        }
    }
}
