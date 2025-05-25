using chronovault_api.Model;
using chronovault_api.Model.Request;
using chronovault_api.Model.Response;

namespace chronovault_api.Mappers
{
    public static class ProductMapper
    {
        public static ProductViewModel ToViewmodel(Product model)
        {
            return new ProductViewModel
            {
                Brand = model.Brand,
                Model = model.Model,
                Price = model.Price,
                ImagesUrls = model.ImagesUrls,
            };
        }

        public static List<ProductViewModel> ToViewmodelList(List<Product> modelList)
        {
            var productViewmodels = new List<ProductViewModel>();

            foreach (var model in modelList)
            {
                productViewmodels.Add(new ProductViewModel
                {
                    Brand = model.Brand,
                    Model = model.Model,
                    Price = model.Price,
                    ImagesUrls = model.ImagesUrls,
                });
            }

            return productViewmodels;
        }

        public static Product ToEntity(ProductCreateRequest model)
        {
            return new Product()
            {
                Brand = model.Brand,
                Model = model.Model,
                Price = model.Price,
            };
        }
    }
}
