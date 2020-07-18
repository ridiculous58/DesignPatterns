using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFreamworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text.ToString(),
                UnitPrice = Convert.ToDecimal(tbxunitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)

            });
            LoadProducts();
            MessageBox.Show("Added Success");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName2.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxunitPrice2.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmount2.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = (int)dgwProducts.CurrentRow.Cells[0].Value,
                Name = tbxName2.Text.ToString(),
                StockAmount = Convert.ToInt32(tbxStockAmount2.Text),
                UnitPrice = Convert.ToDecimal(tbxunitPrice2.Text)
            });
            LoadProducts();
            MessageBox.Show("Update Success");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = (int)dgwProducts.CurrentRow.Cells[0].Value
            });

            LoadProducts();
            MessageBox.Show("Deleted Success");
        }
    }
}
