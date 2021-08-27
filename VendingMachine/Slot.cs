using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Slot
    {
        public Slot()
        {
            Name = null;
            Price = 0;
            _productList = new List<Atıştırmalık>();


        }



        public string Name { get; set; }

        public decimal Price { get; set; }


        private string _slotName;

        public string SlotName
        {
            get { return _slotName; }
            set { _slotName = value; }
        }


        private bool _hasProduct;

        public bool HasProduct
        {
            get { return _hasProduct; }
            set { _hasProduct = value; }
        }

        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public  List<Atıştırmalık> _productList;

      


    }
}
