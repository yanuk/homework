using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace eseential2_2
{
    class Converter
    {
        private double usd, euro, rub;
        public Converter(double usd, double euro, double rub)
        {
            this.usd = usd;
            this.euro = euro;
            this.rub = rub;
        }
        public double UsdToGrivna(double usdSum)
        {
            return (usdSum * usd);
        }
        public double GrivnaToUsd(double grivnaSum)
        {
            return (grivnaSum / usd);
        }

        public double RubToGrivna(double rubSum)
        {
            return (rubSum * rub);
        }
        public double GrivnaToRub(double grivnaSum)
        {
            return (grivnaSum / rub);
        }
        public double EuroToGrivna(double euroSum)
        {
            return (euroSum * euro);
        }
        public double GrivnaToEuro(double grivnaSum)
        {
            return (grivnaSum / euro);
        }
    }
}
