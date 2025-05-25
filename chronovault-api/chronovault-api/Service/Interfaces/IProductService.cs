using chronovault_api.Model.Request;
using chronovault_api.Model.Response;

namespace chronovault_api.Service.Interfaces
{
    public interface IProductService
    {
        List<ProductViewModel> GetAllProducts();
        void CreateProduct(ProductCreateRequest productInformation);
    }
}
