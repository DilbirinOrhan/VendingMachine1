using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public enum SütMiktarı { Az, Orta, Çok}
    public interface IKutuiçecek
    {
        string Name { get; }
        decimal Price { get; }
    }

    public interface Atıştırmalık
    {
        string Name { get; }
        decimal Price { get; }
    }

    public interface IKahve
    {
        string Name { get; }
        decimal Price { get; }
        void Karıştır();
        void SütAl(SütMiktarı miktar);
        void ŞekerAl(int küp);
    }

    public interface IPara
    {
        decimal Değer { get; }
    }
    public interface IÜrünYuvası
    {

        decimal ProductPrice { get; }

        string ProductName { get; }
        string SlotCode { get; }

        bool HasProduct { get; }


    }
}
