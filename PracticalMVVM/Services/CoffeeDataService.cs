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

            coffees.Add(new Coffee { Id = 1, Name = "Fair Trade Rwandan Blend", Description = "A hint of dark fruits with chocolate and mild nuttiness. Smooth and light acidity.", Price = 57.60m, StockAmount = 24, FirstAdded = DateTime.Today, ThumbnailPath = "Images/beans-light.jpg" });
            coffees.Add(new Coffee { Id = 2, Name = "Fair Trade Etheopian Blend", Description = "Dry nuttiness with a biscuit nose and finish. Medium body with a moderate to high acidity.", Price = 65.50m, StockAmount = 12, FirstAdded = DateTime.Today, ThumbnailPath = "Images/beans-peaberry.jpg" });
            coffees.Add(new Coffee { Id = 3, Name = "Fair Trade Columbian Blend", Description = "Dark roasted nuttiness with a tart fruity acidity. Well balanced.", Price = 82.00m, StockAmount = 6, FirstAdded = DateTime.Today, ThumbnailPath = "Images/beans-dark.jpg" });
            coffees.Add(new Coffee { Id = 4, Name = "Italian Dark Roast", Description = "A hint of plums on the nose with a dark roasted body. A high acidity with dark chocolate notes.", Price = 80.75m, StockAmount = 18, FirstAdded = DateTime.Today, ThumbnailPath = "Images/beans-superdark.jpg" });
            coffees.Add(new Coffee { Id = 5, Name = "Nicaraguan Medium Roast", Description = "Medium roast with a smooth flavour of biscuit and chocolate. Medium to low acidity for all day drinking.", Price = 79.50m, StockAmount = 28, FirstAdded = DateTime.Today, ThumbnailPath = "Images/beans-dark2.jpg" });

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
