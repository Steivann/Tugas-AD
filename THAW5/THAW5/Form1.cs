using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace THAW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bantu = 0;
        int bantu2 = 0;
        string buatproduk = "";
        string buatcategory = "";
        string simpen1 = "";
        public int bntuan = 0;
        DataTable produk = new DataTable();
        DataTable category = new DataTable();
        DataTable filter = new DataTable();
        List<string> Category = new List<string>() { "C1", "C2", "C3", "C4", "C5" };
        List<string> list = new List<string>() { "Jas", "T-Shirt", "Rok", "Celana", "Cawat" };
        public void buatbaru()
        {
            cmbo_categorydetail.Items.Clear();

            foreach (var a in list)
            {
                cmbo_categorydetail.Items.Add(a);
            }
        }

        public void buatfilter()
        {
            cmbo_listproduk.Items.Clear();

            foreach (var a in list)
            {
                cmbo_listproduk.Items.Add(a);
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            produk.Columns.Add("ID Product");
            produk.Columns.Add("Nama Product");
            produk.Columns.Add("Harga");
            produk.Columns.Add("Stock");
            produk.Columns.Add("ID Category");
            dgv_product.DataSource = produk;
            produk.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            produk.Rows.Add("T001", "T - Shirt Black Pink", 70000, 20, "C2");
            produk.Rows.Add("T002", "T-Shirt Obsessive", 75000, 16, "C2");
            produk.Rows.Add("R001", "Rok mini", 82000, 26, "C3");
            produk.Rows.Add("J002", "Jeans Biru", 90000, 5, "C4");
            produk.Rows.Add("C001", "Celana Pendek Coklat", 60000, 11, "C4");
            produk.Rows.Add("C002", "Cawat Blink-blink", 1000000, 1, "C5");
            produk.Rows.Add("R002", "Rocca Shirt", 50000, 8, "C2");

            category.Columns.Add("ID Category");
            category.Columns.Add("Nama Category");
            category.Rows.Add("C1", "Jas");
            category.Rows.Add("C2", "T-Shirt");
            category.Rows.Add("C3", "Rok");
            category.Rows.Add("C4", "Celana");
            category.Rows.Add("C5", "Cawat");
            dgv_category.DataSource = category;

            filter.Columns.Add("ID Product");
            filter.Columns.Add("Nama Product");
            filter.Columns.Add("Harga");
            filter.Columns.Add("Stock");
            filter.Columns.Add("ID Category");
            buatbaru();
            buatfilter();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_name_details.Text == "" || textBox_harga.Text == "" || textBox_stock.Text == "" || cmbo_categorydetail.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Error please input");
            }
            else
            {
                for (int i = 0; i < produk.Rows.Count; i++)
                {
                    if (textBox_name_details.Text[0].ToString().ToUpper() == produk.Rows[i][0].ToString()[0].ToString());
                    {
                        bantu = Convert.ToInt32(produk.Rows[i][0].ToString().Substring(1));
                        if(bantu >= bantu2)
                        {
                            bantu2 = bantu;
                        }
                    }
                }
                bantu2 = bantu2 + 1;
                buatproduk = textBox_name_details.Text[0].ToString().ToUpper();
                for (int i = bantu2.ToString().Length; i < 3; i++)
                {
                    buatproduk += "0";
                }
                buatproduk += Convert.ToString(bantu2);
                for (int i = 0; i < category.Rows.Count; i++)
                {
                    if (category.Rows[i][1].ToString() == cmbo_categorydetail.SelectedItem.ToString())
                    {
                        buatcategory = category.Rows[i][0].ToString();
                    }
                }
                produk.Rows.Add(buatproduk, textBox_name_details.Text, textBox_harga.Text, textBox_stock.Text, buatcategory);
                textBox_name_details.Clear();
                textBox_harga.Clear();
                textBox_stock.Clear();
               

            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            cmbo_listproduk.Enabled = true;
        }

        private void Btn_all_Click(object sender, EventArgs e)
        {
            cmbo_listproduk.Enabled = false;
            dgv_product.DataSource = produk;

        }

        private void cmbo_categorydetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox_name_category.Text == "")
            {
                MessageBox.Show("Error please input first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                int ada = 0;
                bool cek = false;
                foreach(DataRow a in category.Rows)
                {
                    bantu = Convert.ToInt32(a[0].ToString().Substring(1));
                    if (ada <= bantu )
                    {
                        ada = bantu;
                    }
                        
                }
                string buat = "C" + (ada + 1);

                foreach(var b in list)
                {

                    if (b == textBox_name_category.Text)
                    {
                        MessageBox.Show("Category already input");
                        cek = false;
                        break;

                    }
                    else
                    {
                        cek = true;
                    }
                  
                }
                
                if (cek == true)
                {
                    //buatbaru();
                   // buatfilter();
                    category.Rows.Add(buat, textBox_name_category.Text);
                    cmbo_listproduk.Items.Add(textBox_name_category.Text);
                    cmbo_categorydetail.Items.Add(textBox_name_category.Text);
                } 
            }
            textBox_name_category.Clear();
            
        }

        private void cmbo_listproduk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string gatau = "";
            filter.Rows.Clear();
           foreach(DataRow a in category.Rows)
            {
                if (cmbo_listproduk.Text == a[1])
                {
                    gatau = a[0].ToString();
                }
            }
            for (int a = 0; a < produk.Rows.Count; a++)
            {
                if (gatau == produk.Rows[a][4].ToString())
                {
                    filter.Rows.Add(produk.Rows[a][0], produk.Rows[a][1], produk.Rows[a][2], produk.Rows[a][3], produk.Rows[a][4]);
                }
            }
            dgv_product.DataSource = filter;
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_name_details_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_harga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool cekisi = true;
            int simpan = 1;
            cmbo_listproduk.Items.Remove(dgv_category.SelectedCells[0].Value.ToString());
            cmbo_categorydetail.Items.Remove(dgv_category.SelectedCells[0].Value.ToString());
            for (int i = produk.Rows.Count - 1; i >= 0; i--)
            {
                if (produk.Rows[i][4].ToString() == dgv_category.SelectedCells[0].Value.ToString())
                {
                    dgv_category.Rows.RemoveAt(i);
                }
            }
            foreach (DataRow a in category.Rows)
            {
                if (a[1].ToString() == simpen1)
                {

                    category.Rows.Remove(a);
                    break;
                }
                dgv_category.Rows.RemoveAt(dgv_category.CurrentCell.RowIndex);
                break;
            }
            for (int i = 0; i < category.Rows.Count; i++)
            {

                if (list[i] == category.Rows[i][1].ToString()) 
                {

                    cekisi = true;
                    simpan = i;

                }
            }



            if (cekisi == true)
            {
                list.RemoveAt(simpan);
                Category.RemoveAt(simpan);
            }
            buatbaru();
            buatfilter();
        }
        DataGridViewRow passRow = null;
        public int index = 0;

        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            passRow = dgv_category.Rows[e.RowIndex];
            index = dgv_category.SelectedCells[0].RowIndex;
            textBox_name_category.Text = category.Rows[index][1].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            if (textBox_name_details.Text == "" || textBox_harga.Text == "" || textBox_stock.Text == "" || cmbo_categorydetail.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Error please input first");
            }
            else
            {
                if (textBox_stock.Text == "0")
                {
                    produk.Rows.RemoveAt(dgv_product.SelectedRows[0].Index);
                    
                    
                }
                else
                {
                    produk.Rows[bntuan][1] = textBox_name_details.Text;
                    produk.Rows[bntuan][3] = textBox_stock.Text;
                    produk.Rows[bntuan][2] = textBox_harga.Text;
                    for (int i = 0; i < Category.Count; i++)
                    {
                        if (cmbo_categorydetail.SelectedItem == list[i])
                        {
                            produk.Rows[bntuan][4] = Category[i];
                        }
                    }
                    dgv_product.DataSource = produk;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv_product.SelectedCells.Count > 0)
            {
                produk.Rows.RemoveAt(dgv_product.CurrentCell.RowIndex);
            }
            else
            {

                MessageBox.Show(" Pilih dulu ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
  