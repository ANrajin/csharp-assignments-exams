using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ShoppingCart
    {
        private List<IProduct> _items;

        public ShoppingCart()
        {
            _items = new List<IProduct>();
        }

        public void AddItem(IProduct item)
        {
            _items.Add(item);
        }

        public int GetTotalItemCount()
        {
            return _items.Count;
        }
    }
}
