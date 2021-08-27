using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class AtıstırmalıkOtomat<TEntity> where TEntity :Atıştırmalık
    {

       public  static  List<Slot> _slotList;
        static  AtıstırmalıkOtomat()
        {
            _slotList = new List<VendingMachine.Slot>();
            for (int i = 0; i < 20; i++)
            {
                Slot slot = new VendingMachine.Slot();
                slot.SlotName = "A" + i;
                slot.HasProduct = false;
                slot.Count = 0;

                _slotList.Add(slot);
                
            }
        }
      public void AddProduct<Tentity>(Tentity product,int slotNumber) where  Tentity:Atıştırmalık
        {
            if (_slotList[slotNumber].Count<10)
            {
                _slotList[slotNumber].Name = product.Name;
                _slotList[slotNumber].Price = product.Price;
                _slotList[slotNumber]._productList.Add(product);
                _slotList[slotNumber].HasProduct = true;
                _slotList[slotNumber].Count++;
            }
            else
            {
                throw new Exception("Bu slota daha fazla ürün ekleyemezsiniz");
            }
            
            
        }

        






    }
}
