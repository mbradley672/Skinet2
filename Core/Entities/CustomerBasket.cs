using System.Collections.Generic;

namespace Core.Entities {
    public class CustomerBasket {
        public CustomerBasket(string id) {
            Id = id;
        }

        public CustomerBasket() {
            
        }

        public string Id { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }

    public class BasketItem {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}