namespace chronovault_api.Model.Response
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public List<string> ImagesUrls { get; set; }
    }
}
