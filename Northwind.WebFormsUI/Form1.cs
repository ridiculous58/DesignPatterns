using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            _product = InstanceFactory.GetInstance<IProductService>();
            _category= InstanceFactory.GetInstance<ICategoryService>();

        }

        private IProductService _product;
        private ICategoryService _category;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _category.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _category.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            cbxCategoryIdUpdate.DataSource = _category.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";

        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _product.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxCategory.SelectedValue != null )
                {
                    dgwProduct.DataSource = _product.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
                }
                else
                {
                    LoadProducts();
                }
               
            }
            catch 
            {
               
            }
           
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _product.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();;
            }
            
      
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                _product.Add(new Product
                {

                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName2.Text,
                    QuantityPerunit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)
                });
                MessageBox.Show("Added!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _product.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                ProductName = tbxUpdateProductName.Text,
                QuantityPerunit = tbxQuantityPerUnitUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                UnitsInStock = Convert.ToInt16(tbxUnitInStockUpdate.Text)

            });
            MessageBox.Show("Updated!");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = dgwProduct.CurrentRow.Cells["QuantityPerUnit"].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProduct.CurrentRow.Cells["UnitPrice"].Value.ToString();
            cbxCategoryIdUpdate.SelectedValue = dgwProduct.CurrentRow.Cells["CategoryId"].Value;
            tbxUnitInStockUpdate.Text = dgwProduct.CurrentRow.Cells["UnitsInStock"].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _product.Delete(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Deleted!");
            LoadProducts();

            

        }
    }
}
