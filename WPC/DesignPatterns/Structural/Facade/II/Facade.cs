﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.II
{
    internal class Facade
    {
        ICartService cartService;
        IProductService productService;
        IPaymentService paymentService;

        public Facade(ICartService cartService, IProductService productService, IPaymentService paymentService)
        {
            this.cartService = cartService;
            this.productService = productService;
            this.paymentService = paymentService;
        }

        public void Buy(int[] productIds)
        {
            foreach (var productId in productIds)
            {
                var price = productService.GetPrice(productId);
                cartService.AddProduct(productId, price);
            }
            paymentService.Pay(cartService.GetId(), cartService.GetValute());
        }
    }
}
