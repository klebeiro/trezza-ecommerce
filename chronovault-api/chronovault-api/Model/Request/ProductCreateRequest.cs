namespace chronovault_api.Model.Request
{
    public class ProductCreateRequest
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        private List<string> ImagesUrls { get; set; }
    }
}
