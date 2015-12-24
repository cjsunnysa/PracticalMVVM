using System;
using System.ComponentModel;
using System.Windows;

namespace PracticalMVVM.DataTypes
{
    public class Coffee : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _description;
        private int _intensity;
        private decimal _price;
        private int _stockAmount;
        private DateTime _firstAdded;

        public int Id
        {
            get { return _id; }
            set
            {
                if (_id == value)
                    return;

                _id = value;
                OnPropertyChanged("StockCode");
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == value)
                    return;

                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description == value)
                    return;

                _description = value;
                OnPropertyChanged("Description");
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price == value)
                    return;

                _price = value;
                OnPropertyChanged("Price");
            }
        }
        public int StockAmount
        {
            get
            {
                return _stockAmount;
            }
            set
            {
                if (_stockAmount == value)
                    return;

                _stockAmount = value;
                OnPropertyChanged("StockAmount");
            }
        }
        public DateTime FirstAdded
        {
            get
            {
                return _firstAdded;
            }
            set
            {
                if (_firstAdded == value)
                    return;

                _firstAdded = value;
                OnPropertyChanged("FirstAdded");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}