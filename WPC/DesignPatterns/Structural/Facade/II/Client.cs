using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.II
{
    internal class Client
    {
        static ICartService cartService;
        static IProductService productService;
        static IPaymentService paymentService;

        public static void Execute()
        {
            int[] productIds = new[] { 2, 63, 21, 7 };

            /*foreach (var productId in productIds)
            {
                var price = productService.GetPrice(productId);
                cartService.AddProduct(productId, price);
            }
            paymentService.Pay(cartService.GetId(), cartService.GetValute());*/

            var shop = new Facade(cartService, productService, paymentService);

            shop.Buy(productIds);
        }

    }
}
