using ApplicationCore.Interfaces;
using ApplicationCore.Model;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    public class EfProductRepository : IProductRepository
    {
        private readonly NorthwindContext _dbContext;

        public EfProductRepository(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Products> GetAll()
        {
            return _dbContext.Products.ToList();
        }
    }
}
