using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqProject
{
    public partial class Form1 : Form
    {
        int[] sayilar = { 5, -4, 19, 22, -12, 11, 16, -7 };
        List<string> isimler = new List<string>() { "emirhan", "ali", "veli", "miray", "alperen" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTumSayilar_Click(object sender, EventArgs e)
        {
            lstbxResult.DataSource = null;
            lstbxResult.DataSource = sayilar;
        }

        private void btnNagatifler_Click(object sender, EventArgs e)
        {
            IEnumerable<int> negatifSayilar = sayilar.Where(x => x < 0);
            lstbxResult.DataSource = null;
            lstbxResult.DataSource = negatifSayilar.ToList();
        }

        private void btnPozitifSayilar_Click(object sender, EventArgs e)
        {
            IEnumerable<int> pozitifSayilar = sayilar.Where(x => x > 0);
            lstbxResult.DataSource = null;
            lstbxResult.DataSource = pozitifSayilar.ToList();

        }

        private void btnCift_Click(object sender, EventArgs e)
        {
            IEnumerable<int> pozitifSayilar = sayilar.Where(x => x % 2 == 0 && x >= 0);
            lstbxResult.DataSource = null;
            lstbxResult.DataSource = pozitifSayilar.ToList();
        }

        private void btnTek_Click(object sender, EventArgs e)
        {
            IEnumerable<int> pozitifSayilar = sayilar.Where(x => x % 2 == 1 && x >= 0);
            lstbxResult.DataSource = null;
            lstbxResult.DataSource = pozitifSayilar.ToList();
        }

        private void btnEnBuyuk_Click(object sender, EventArgs e)
        {
            int max = (from sayi in sayilar select sayi).Max();
            MessageBox.Show(max.ToString());
        }

        private void btnEnkucuk_Click(object sender, EventArgs e)
        {
            int min = (from sayi in sayilar select sayi).Min();
            MessageBox.Show(min.ToString());
        }

        private void btnKacTane_Click(object sender, EventArgs e)
        {
            int kacSayiVar = sayilar.Count();
            MessageBox.Show(kacSayiVar.ToString());
        }

        private void btnAdlar_Click(object sender, EventArgs e)
        {
            var result = isimler.OrderBy(x=> x);
            lstbxResult.DataSource = null;
            lstbxResult.DataSource=result.ToList();
        }

        private void btnTersAlfabe_Click(object sender, EventArgs e)
        {
            var result = from isim in isimler
                         orderby isim descending
                         select isim;
            lstbxResult.DataSource = null;
            lstbxResult.DataSource = result.ToList();
        }

        private void btnAdUzunluk_Click(object sender, EventArgs e)
        {
            lstbxResult.DataSource = null;
            lstbxResult.DataSource = isimler.Select(x => x.Length).ToList();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            lstbxResult.DataSource = null;
            lstbxResult.DataSource = isimler.Where(x => x.Contains("n") || x.Contains("N")).ToList();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            lstbxResult.DataSource = null;
            lstbxResult.DataSource = isimler.Where(x=>x.StartsWith("E")|| x.StartsWith("e")).ToList();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            var result = orders.Select(x => new
            {
                siparisNo = x.orderId,
                tarih = x.orderDate,
                musteri = x.customer.contactName
            }
            );
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.ToList();
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Select(x => x.orderDate).ToList();
        }

        private void btnTop5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void btnYang_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            var filter = orders.Where(x => x.customer.contactName == "Yang Wang").ToList();
            dataGridView1.DataSource = filter;

        }

        private void btnSiparisSayisi_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            MessageBox.Show(orders.Count().ToString());
        }
    }
}
