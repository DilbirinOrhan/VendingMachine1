using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Atırştırmalık biskrem = new VendingMachine.Atırştırmalık("biskrem",12);
            Kutuiçecek kola = new Kutuiçecek("Kola", 5);

            AtıstırmalıkOtomat<Atıştırmalık> ao = new VendingMachine.AtıstırmalıkOtomat<Atıştırmalık>();

            ao.AddProduct<Atıştırmalık>(biskrem, 2);
            ao.AddProduct<Atıştırmalık>(biskrem, 2);
            ao.AddProduct<Atıştırmalık>(biskrem, 2);
            ao.AddProduct<Atıştırmalık>(biskrem, 2);
            ao.AddProduct<Atıştırmalık>(biskrem, 2);
            ao.AddProduct<Atıştırmalık>(biskrem, 2);



            MessageBox.Show(AtıstırmalıkOtomat<Atıştırmalık>._slotList[2].Count.ToString());



        }
    }
}
