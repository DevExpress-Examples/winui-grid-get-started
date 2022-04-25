using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace GridGetStarted {
    public class Product {
        public Product(string productName, string country, DateTime orderDate, double unitPrice, int quantity) {
            ProductName = productName;
            Country = country;
            OrderDate = orderDate;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
        public string ProductName { get; set; }
        public string Country { get; set; }
        public DateTime OrderDate { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
    public class ProductData {
        public static ObservableCollection<Product> GetProducts() {
            var products = Enumerable.Range(0, 500).Select(i => { // <- The total number of items.
                return new Product(
                    productName: DataGenerator.GetProductName(),
                    country: DataGenerator.GetCountry(),
                    orderDate: DataGenerator.GetOrderDate(),
                    unitPrice: DataGenerator.GetUnitPrice(),
                    quantity: DataGenerator.GetQuantity()
                );
            });
            return new ObservableCollection<Product>(products);
        }
    }
}
