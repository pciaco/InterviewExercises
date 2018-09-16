using SalesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesClient
{
    
    public partial class Form1 : Form
    {
        private string[] productTypes = new string[] { "Book", "Food", "Medical Product", "Other" };
        BindingSource source = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            this.cmbProductTypes.DataSource = productTypes;
            this.cmbProductTypes.SelectedIndex =3;
            source.DataSource = ReceiptManager.Instance.getProducts();
            grdProductList.DataSource = source;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double productPrice = Convert.ToDouble(this.txtPrice.Text);
            string productName = this.txtName.Text;
            int qta = Convert.ToInt32(this.txtQta.Text);
            bool isImported = this.chkImported.Checked;
            bool isTaxed = (this.cmbProductTypes.SelectedValue.Equals("Other") ? true : false);

            ReceiptManager.Instance.addProduct(productName, productPrice, qta, isImported, isTaxed);
            this.lblTotalValue.Text = ReceiptManager.Instance.getTotal().ToString();
            this.lblTotalTaxValue.Text = ReceiptManager.Instance.getTotalTax().ToString();

            source.ResetBindings(false);
            clearInputData(false);
        }

        private void clearInputData(bool clearReceipt)
        {
            this.txtName.Text = "";
            this.txtPrice.Text = "";
            this.txtQta.Text = "";
            this.chkImported.Checked = false;
            this.cmbProductTypes.SelectedIndex = 3;
            if (clearReceipt)
            {
                this.lblTotalValue.Text = "0,0";
                this.lblTotalTaxValue.Text = "0,0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ReceiptManager.Instance.clearReceipt();
            this.grdProductList.Rows.Clear();
            this.grdProductList.Refresh();
            source.DataSource = ReceiptManager.Instance.getProducts();
            grdProductList.DataSource = source;
            clearInputData(true);
        }

        private void qta_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtQta.Text, "  ^ [0-9]"))
            {
                this.txtQta.Text = "";
            }
        }
        private void qta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
