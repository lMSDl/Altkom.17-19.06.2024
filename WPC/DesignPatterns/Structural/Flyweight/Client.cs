namespace WPC.DesignPatterns.Structural.Flyweight
{
    internal class Client
    {


        public static void Execute()
        {
            FlyweightFactory.Instance.Initialize(
                new ProductFlyweight
                {
                    Name = "N1",
                    Description = "D1",
                    Logo = new byte[1024],
                    Weight = 100,
                    Manufacturer = "M1"
                },
                new ProductFlyweight
                {
                    Name = "N2",
                    Description = "D2",
                    Logo = new byte[1024],
                    Weight = 200,
                    Manufacturer = "M2"
                });

            Console.WriteLine(FlyweightFactory.Instance);

            var product1 = new Product
            {
                Name = "N1",
                Description = "D1",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Logo = new byte[1024],
                Weight = 100,
                Manufacturer = "M1"
            };

            //product1.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product1.ProductFlyweight);


            var product11 = new Product
            {
                Name = "N1",
                Description = "D1",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Logo = new byte[1024],
                Weight = 100,
                Manufacturer = "M1"
            };
            //product11.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product11.ProductFlyweight);


            //product11.ProductFlyweight = new ProductFlyweight { Weight = 200, Logo = product11.Logo, Description = product11.Description, Manufacturer = product11.Manufacturer, Name = product11.Name };
            //product11.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product11.ProductFlyweight);

            Console.WriteLine(FlyweightFactory.Instance);

            var product12 = new Product
            {
                Name = "N1",
                Description = "D1",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Logo = new byte[1024],
                Weight = 100,
                Manufacturer = "M1"
            };
            //product12.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product12.ProductFlyweight);

            var product2 = new Product
            {
                Name = "N2",
                Description = "D2",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Logo = new byte[1024],
                Weight = 100,
                Manufacturer = "M1"
            };
            //product2.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product2.ProductFlyweight);


            Console.WriteLine(FlyweightFactory.Instance);

            Show(product1);
            Show(product2);

            product1.ShowShortInfo();
        }

        public static void Show(Product product)
        {
            Console.WriteLine($"{product.Name}; {product.Description}; {product.Manufacturer}; {product.ProductionDate.ToShortDateString()}; {product.ExpirationDate.ToShortDateString()}");
        }
    }
}
