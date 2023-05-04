using System;
namespace OOP_Day1_Homework
{
	public class VatCalculator
	{
        public decimal CaluculateVat(decimal saleTotal, string country)
        {
            decimal vatRate;

            switch(country.ToLower())
            {
                case "armenia":
                    vatRate = 0.20m;
                    break;

                case "usa":
                    vatRate = 0.20m;
                    break;

                default:
                    vatRate = 0.20m;
                    break;
            }

            decimal vat = saleTotal * vatRate;

            return vat;
        }
    }
}

