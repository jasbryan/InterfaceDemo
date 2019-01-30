using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    //public delegate void PriceChangeHandler(decimal oldPrice, decimal newPrice);


    class Stock
    {
        #region Properties

        private decimal _price;

        public string Symbol { get; set; }



        public decimal Price {
            get { return _price; }
            set
            {
                PriceChanged?.Invoke(new PriceChangedEventArgs
                {
                    OldPrice = _price,
                    NewPrice = value
                });
                _price = value;
            }
        }

        #endregion

        #region Methods

        public event Action<PriceChangedEventArgs> PriceChanged;




        #endregion



    }

    class PriceChangedEventArgs : EventArgs
    {
        public decimal OldPrice { get; set; }

        public decimal NewPrice { get; set; }
    }
}
