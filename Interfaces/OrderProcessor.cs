using System;

namespace InterfacesTestability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed");
            order.shipment = new Shipment();
            order.shipment.Cost = _shippingCalculator.CalculateShipping(order);
            order.shipment.ShippingDate = DateTime.Today.AddDays(1);
        }

    }
}