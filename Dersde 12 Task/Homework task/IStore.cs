using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_task
{
    internal interface IStore
    {
        public Product[] Products { get; set; }
        public void AddProduct(Product product);
        public bool HasProductByNo(int no);
        public Product GetProductByNo(int no);
        public Drink[] GetDrinkProducts();
        public Dairy[] GetDairyProducts();
        public void RemoveProduct(int no); 

    }
}
