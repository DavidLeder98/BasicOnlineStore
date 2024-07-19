using System.ComponentModel;

namespace BasicOnlineStore.Models
{
    public class ProductModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }

        [DisplayName("Product")]
        public string Name { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }
    }
}
