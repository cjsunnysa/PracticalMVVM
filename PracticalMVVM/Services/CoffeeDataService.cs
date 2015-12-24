using PracticalMVVM.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticalMVVM.Services
{
    public class CoffeeDataService : IDataService<Coffee, string>
    {
        private List<Coffee> _data;

        public CoffeeDataService()
        {
            _data = CreateData();
        }

        private List<Coffee> CreateData()
        {
            var coffees = new List<Coffee>();

            coffees.Add(new Coffee { Id = 1, Name = "Fair Trade Rwandan Blend", Price = 57.60m, StockAmount = 24, FirstAdded = DateTime.Today });
            coffees.Add(new Coffee { Id = 2, Name = "Fair Trade Etheopian Blend", Price = 65.50m, StockAmount = 12, FirstAdded = DateTime.Today });
            coffees.Add(new Coffee { Id = 3, Name = "Fair Trade Columbian Blend", Price = 82.00m, StockAmount = 6, FirstAdded = DateTime.Today });
            coffees.Add(new Coffee { Id = 4, Name = "Italian Dark Roast", Price = 80.75m, StockAmount = 18, FirstAdded = DateTime.Today });
            coffees.Add(new Coffee { Id = 5, Name = "Nicaraguan Medium Roast", Price = 79.50m, StockAmount = 28, FirstAdded = DateTime.Today });

            return coffees;
        }

        public IEnumerable<Coffee> GetAll()
        {
            return _data.ToArray();
        }

        public Coffee GetById(string stockCode)
        {
            return _data.FirstOrDefault(c => c.Id.Equals(stockCode));
        }

        public void Save(Coffee record)
        {
            var existing = _data.FirstOrDefault(c => c.Id.Equals(record.Id));
            if (existing == null)
            {
                _data.Add(record);
                return;
            }

            existing = record;
        }

        public void Delete(Coffee record)
        {
            var existing = _data.FirstOrDefault(c => c.Id.Equals(record.Id));
            if (existing == null)
                return;

            _data.Remove(existing);
        }
    }
}
