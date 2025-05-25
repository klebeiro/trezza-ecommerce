using chronovault_api.Infra.Data;
using chronovault_api.Mappers;
using chronovault_api.Model.Request;
using chronovault_api.Model.Response;
using chronovault_api.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace chronovault_api.Service
{
    public class ProductService : IProductService
    {
        private ChronovaultDbContext _dbContext;

        public ProductService(ChronovaultDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        public void CreateProduct(ProductCreateRequest productInformation)
        {
            var existentProduct = _dbContext.Products.FirstOrDefault(p => p.Model == productInformation.Model && p.Brand == productInformation.Brand && p.Price == productInformation.Price);

            if (existentProduct != null) 
            {
                {
                    throw new Exception("Produto já existe");
                }
            }

            _dbContext.Products.Add(ProductMapper.ToEntity(productInformation));
            _dbContext.SaveChanges();
        }

        public List<ProductViewModel> GetAllProducts()
        {
            var products = _dbContext.Products.ToList();
            return ProductMapper.ToViewmodelList(products);
        }
    }
}
