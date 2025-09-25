using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalCost()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.GetTotalCost();
            }
            // Add shipping cost: $5 for USA, $35 for non-USA
            total += _customer.LivesInUSA() ? 5.0 : 35.0;
            return total;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (Product product in _products)
            {
                label += $"Product: {product.GetName()}, ID: {product.GetProductId()}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        }
    }
}