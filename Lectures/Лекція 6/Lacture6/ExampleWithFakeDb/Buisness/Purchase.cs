using System;

namespace ExampleWithFakeDb.Buisness
{
    public class Purchase : IPurchase
    {
        public decimal Cost
        {
            get
            {
                return CalculateCosts();
            }
        }

        public DateTime PurchaseDate { get; }

        private Commodity[] _commodities;

        public Purchase(params Commodity[] parameters)
        {
            PurchaseDate = DateTime.Now;
            _commodities = parameters ?? new Commodity[0];
        }

        private decimal CalculateCosts()
        {
            var result = 0.0m;
            for (int i = 0; i < _commodities.Length; i++)
            {
                var commodity = _commodities[i];
                result += commodity.Price;
            }

            return result;
        }
    }
}
