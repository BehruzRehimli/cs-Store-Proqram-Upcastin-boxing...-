using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Homework_task.Exceptions;

namespace Homework_task
{
    internal class Store : IStore
    {
        private Product[] _products= new Product[0];
        public Product[] Products { get => _products; set => value=_products; }
        private int _alcholPercentLimit=100;
        public int AlcoholPercentLimit
        {
            get => _alcholPercentLimit;
            set
            {
                if (value>=0&&value<=100)
                {
                    _alcholPercentLimit = value;
                }
                else { throw new PercentException(); }
            }
        }
        private int _dairyProductCountLimit = 999999999;
        public int DairyProductCountLimit { get => _dairyProductCountLimit; 
            set
            {
                if (value>=0)
                {
                    _dairyProductCountLimit = value;
                }
            }  }

        public void AddProduct(Product product)
        {
            int dairycount = 0;
            if (product is Drink)
            {
                var drink = (Drink)product;
                if (drink.AlcoholPercent>_alcholPercentLimit)
                {
                    throw new PercentLimitException();
                }
                else
                {
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;
                }
            }
            else
            {
                foreach (var item in _products)
                {
                    if (item is Dairy)
                    {
                        dairycount++;
                    }
                }
                if (dairycount>=_dairyProductCountLimit)
                {
                    throw new DairyProductLimitBroken();
                }
                else
                {
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;
                }
            }
        }

        public Dairy[] GetDairyProducts()
        {
            Dairy[]darr= new Dairy[0];
            foreach (var item in _products)
            {
                if (item is Dairy)
                {
                    Array.Resize(ref darr,darr.Length+1);
                    darr[darr.Length - 1] = item as Dairy;
                }
            }
            return darr;
        }

        public Drink[] GetDrinkProducts()
        {
            Drink[]darr= new Drink[0];
            foreach (var item in _products)
            {
                if (item is Drink)
                {
                    Array.Resize(ref darr,darr.Length+1);
                    darr[darr.Length - 1]= item as Drink;
                }
            }
            return darr;
        }

        public Product GetProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No==no)
                {
                    return item;
                }
            }
            throw new ThereIsNotProductNo();
        }

        public bool HasProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveProduct(int no)
        {
            Product[] newarr=new Product[0];
            bool hasthisproduct=false;
            foreach (var item in _products)
            {
                if (item.No==no)
                {
                    hasthisproduct = true;
                }
                if (item.No!=no)
                {
                    Array.Resize(ref newarr,newarr.Length+1);
                    newarr[newarr.Length-1]= item;
                }
            }
            if (hasthisproduct==false)
            {
                throw new ThereIsNotProductNo();
            }
            _products = newarr;
        }
    }
}
