using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }
        private ICategoryService _categoryService;
        private IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void LoadCategories()
        {
            cBoxCategories.DataSource = _categoryService.GetAll();
            cBoxCategories.DisplayMember = "CategoryName";
            cBoxCategories.ValueMember = "CategoryId";

            cbCPCategory.DataSource = _categoryService.GetAll();
            cbCPCategory.DisplayMember = "CategoryName";
            cbCPCategory.ValueMember = "CategoryId";

            cbUPCategory.DataSource = _categoryService.GetAll();
            cbUPCategory.DisplayMember = "CategoryName";
            cbUPCategory.ValueMember = "CategoryId";


        }

        private void cBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cBoxCategories.SelectedValue));
            }
            catch
            {


            }
        }

        private void txtBoxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(txtBoxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnCProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbCPCategory.SelectedValue),
                    ProductName = txtCPProductName.Text,
                    QuantityPerUnit = txtCPQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(txtCPPreis.Text),
                    UnitsInStock = Convert.ToInt16(txtCPUnitsInStock.Text)
                });
                MessageBox.Show("Product Created!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = txtUPName.Text,
                    CategoryId = Convert.ToInt32(cbUPCategory.SelectedValue),
                    UnitsInStock = Convert.ToInt16(txtUPUnitsInStock.Text),
                    QuantityPerUnit = txtUPQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(txtUPPreis.Text)
                });
                MessageBox.Show("Product Updated!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            txtUPName.Text = row.Cells[1].Value.ToString();
            cbUPCategory.SelectedValue = row.Cells[2].Value;
            txtUPPreis.Text = row.Cells[3].Value.ToString();
            txtUPQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            txtUPUnitsInStock.Text = row.Cells[5].Value.ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi!");
                    LoadProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
