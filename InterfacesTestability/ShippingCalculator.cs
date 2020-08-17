using System;

namespace InterfacesTestability
{
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.Price < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}