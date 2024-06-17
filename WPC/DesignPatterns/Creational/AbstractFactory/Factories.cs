using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC.SOLID.LSP_1;

namespace WPC.DesignPatterns.Creational.AbstractFactory
{
    public class HondaFactory : ICarFactory
    {
        public ISedan ManufactureSedan(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSedan();
                case "full":
                    return new HondaFullSedan();
            }
            return default;
        }

        public ISuv ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSuv();
                case "full":
                    return new HondaFullSuv();
            }
            return default;
        }
    }

    public class ToyotaFactory : ICarFactory
    {
        ISedan ICarFactory.ManufactureSedan(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new ToyotaCompactSedan();
                case "full":
                    return new ToyotaFullSedan();
                default:
                    throw new Exception();
            }
        }

        ISuv ICarFactory.ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new ToyotaCompactSuv();
                case "full":
                    return new ToyotaFullSuv();
                default:
                    throw new Exception();
            }
        }
    }
}
