using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Ürün
    {
        public string Ad;
        public decimal Fiyat;
    }

    public class Atırştırmalık : Ürün, Atıştırmalık
    {
        string Atıştırmalık.Name
        {
            get { return this.Ad; }
        }
        public Atırştırmalık(string Ad, decimal Fiyat)
        {
            this.Ad = Ad;
            this.Fiyat = Fiyat;
        }

        decimal Atıştırmalık.Price
        {
            get { return this.Fiyat; }
        }
        public override string ToString()
        {
            return this.Ad + " " + this.Fiyat;
        }
    }


    public class Kutuiçecek : Ürün, IKutuiçecek
    {
        public Kutuiçecek(string Ad, decimal Fiyat)
        {
            this.Ad = Ad;
            this.Fiyat = Fiyat;
        }

        string IKutuiçecek.Name
        {
            get { return this.Ad; }
        }

        decimal IKutuiçecek.Price
        {
            get { return this.Fiyat; }
        }
    }


    public class Kahve : Ürün, IKahve
    {
        public bool kahve;
        public int KahveOranı;
        public int SuOranı;
        public int Şeker;
        public int SütMiktarı;

        public void Karıştır() { this.kahve = true; }
        public void SütEkle(int SütMiktarı) { this.SütMiktarı += SütMiktarı; }
        public void ŞekerEkle(int Küp) { this.Şeker += Küp; }

        public Kahve(string Ad, decimal Fiyat, int KahveOranı, int SuOranı)
        {
            this.Ad = Ad;
            this.Fiyat = Fiyat;
            this.KahveOranı = KahveOranı;
            this.SuOranı = SuOranı;
            this.kahve = false;
            this.Şeker = 0;
            this.SütMiktarı = 0;
        }

        string IKahve.Name
        {
            get { return this.Ad; }
        }

        decimal IKahve.Price
        {
            get { return this.Fiyat; }
        }

        void IKahve.Karıştır()
        {
            this.Karıştır();
        }

        void IKahve.SütAl(SütMiktarı miktar)
        {
            switch (miktar)
            {
                case VendingMachine.SütMiktarı.Az: this.SütEkle(50);
                    break;
                case VendingMachine.SütMiktarı.Orta: this.SütEkle(75);
                    break;
                case VendingMachine.SütMiktarı.Çok: this.SütEkle(100);
                    break;
                default:
                    break;
            }
            
        }

        void IKahve.ŞekerAl(int küp)
        {
            this.ŞekerEkle(küp);
        }
    }

    public class Para : IPara
    {
        public string Cins;
        private decimal _değer;
        public decimal Değer
        {
            get
            {
                return _değer;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Para 0 TL den küçük olamaz");
                }
                _değer = value;
            }
        }

        public Para(string Cins, decimal Değer)
        {
            this.Cins = Cins;
            this._değer = Değer;
        }
    }
}
