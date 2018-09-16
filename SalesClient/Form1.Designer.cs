namespace SalesClient
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.GroupBox();
            this.chkImported = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtQta = new System.Windows.Forms.TextBox();
            this.lblQta = new System.Windows.Forms.Label();
            this.cmbProductTypes = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.GroupBox();
            this.grdProductList = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotalTaxValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.input.SuspendLayout();
            this.receipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Controls.Add(this.chkImported);
            this.input.Controls.Add(this.txtPrice);
            this.input.Controls.Add(this.lblPrice);
            this.input.Controls.Add(this.txtName);
            this.input.Controls.Add(this.lblName);
            this.input.Controls.Add(this.txtQta);
            this.input.Controls.Add(this.lblQta);
            this.input.Controls.Add(this.cmbProductTypes);
            this.input.Controls.Add(this.btnAdd);
            this.input.Location = new System.Drawing.Point(28, 12);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(762, 279);
            this.input.TabIndex = 18;
            this.input.TabStop = false;
            this.input.Text = "Input Data";
            // 
            // chkImported
            // 
            this.chkImported.AutoSize = true;
            this.chkImported.Location = new System.Drawing.Point(40, 194);
            this.chkImported.Name = "chkImported";
            this.chkImported.Size = new System.Drawing.Size(95, 21);
            this.chkImported.TabIndex = 18;
            this.chkImported.Text = "isImported";
            this.chkImported.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(117, 154);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(175, 22);
            this.txtPrice.TabIndex = 17;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(37, 157);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 22);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // txtQta
            // 
            this.txtQta.Location = new System.Drawing.Point(117, 83);
            this.txtQta.Name = "txtQta";
            this.txtQta.Size = new System.Drawing.Size(175, 22);
            this.txtQta.TabIndex = 13;
            this.txtQta.TextChanged += new System.EventHandler(this.qta_TextChanged);
            this.txtQta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qta_KeyPress);
            // 
            // lblQta
            // 
            this.lblQta.AutoSize = true;
            this.lblQta.Location = new System.Drawing.Point(37, 86);
            this.lblQta.Name = "lblQta";
            this.lblQta.Size = new System.Drawing.Size(61, 17);
            this.lblQta.TabIndex = 12;
            this.lblQta.Text = "Quantity";
            // 
            // cmbProductTypes
            // 
            this.cmbProductTypes.FormattingEnabled = true;
            this.cmbProductTypes.Location = new System.Drawing.Point(40, 37);
            this.cmbProductTypes.Name = "cmbProductTypes";
            this.cmbProductTypes.Size = new System.Drawing.Size(252, 24);
            this.cmbProductTypes.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // receipt
            // 
            this.receipt.Controls.Add(this.lblTotalValue);
            this.receipt.Controls.Add(this.lblTotalTaxValue);
            this.receipt.Controls.Add(this.grdProductList);
            this.receipt.Controls.Add(this.lblTotal);
            this.receipt.Controls.Add(this.lblTax);
            this.receipt.Controls.Add(this.btnClear);
            this.receipt.Location = new System.Drawing.Point(28, 297);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(762, 396);
            this.receipt.TabIndex = 19;
            this.receipt.TabStop = false;
            this.receipt.Text = "Receipt";
            // 
            // grdProductList
            // 
            this.grdProductList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductList.Enabled = false;
            this.grdProductList.Location = new System.Drawing.Point(14, 33);
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.RowTemplate.Height = 24;
            this.grdProductList.Size = new System.Drawing.Size(739, 264);
            this.grdProductList.TabIndex = 23;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(599, 342);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 18);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Price";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(599, 314);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(78, 18);
            this.lblTax.TabIndex = 19;
            this.lblTax.Text = "Total Tax";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(687, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotalTaxValue
            // 
            this.lblTotalTaxValue.AutoSize = true;
            this.lblTotalTaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTaxValue.Location = new System.Drawing.Point(681, 313);
            this.lblTotalTaxValue.Name = "lblTotalTaxValue";
            this.lblTotalTaxValue.Size = new System.Drawing.Size(31, 18);
            this.lblTotalTaxValue.TabIndex = 24;
            this.lblTotalTaxValue.Text = "0,0";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(681, 342);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(31, 18);
            this.lblTotalValue.TabIndex = 25;
            this.lblTotalValue.Text = "0,0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 698);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "SalesClient";
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            this.receipt.ResumeLayout(false);
            this.receipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox input;
        private System.Windows.Forms.CheckBox chkImported;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtQta;
        private System.Windows.Forms.Label lblQta;
        private System.Windows.Forms.ComboBox cmbProductTypes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox receipt;
        private System.Windows.Forms.DataGridView grdProductList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalTaxValue;
    }
}

