using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanThuanShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private VanThuanShopDbContext dbContext;

        public VanThuanShopDbContext Init()
        {
            return dbContext ?? (dbContext = new VanThuanShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }


}
