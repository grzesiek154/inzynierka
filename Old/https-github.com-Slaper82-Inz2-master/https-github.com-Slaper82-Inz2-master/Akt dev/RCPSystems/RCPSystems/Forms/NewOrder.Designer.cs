namespace RCPSystems.Forms
{
    partial class NewOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(144, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(197, 22);
            this.txtDescription.TabIndex = 0;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(145, 34);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(197, 24);
            this.cmbClient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produkt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ilość";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(412, 37);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(155, 41);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Zatwierdź";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.Ilosc,
            this.Id,
            this.IdProd});
            this.dgvProd.Location = new System.Drawing.Point(31, 399);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowTemplate.Height = 24;
            this.dgvProd.Size = new System.Drawing.Size(641, 206);
            this.dgvProd.TabIndex = 8;
            this.dgvProd.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvProd_RowStateChanged);
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            // 
            // Ilosc
            // 
            this.Ilosc.DataPropertyName = "Ilosc";
            this.Ilosc.HeaderText = "Ilość";
            this.Ilosc.Name = "Ilosc";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // IdProd
            // 
            this.IdProd.DataPropertyName = "IdProd";
            this.IdProd.HeaderText = "IdProd";
            this.IdProd.Name = "IdProd";
            this.IdProd.Visible = false;
            // 
            // cmbProduct
            // 
            this.cmbProduct.Enabled = false;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(144, 28);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(197, 24);
            this.cmbProduct.TabIndex = 9;
            // 
            // txtQuant
            // 
            this.txtQuant.Enabled = false;
            this.txtQuant.Location = new System.Drawing.Point(144, 75);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(197, 22);
            this.txtQuant.TabIndex = 10;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Enabled = false;
            this.btnAddProduct.Location = new System.Drawing.Point(412, 43);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(155, 41);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Dodaj do zamówienia";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lista wybranych produktów";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.txtQuant);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 124);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie produktu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.cmbClient);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAccept);
            this.groupBox2.Location = new System.Drawing.Point(31, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 130);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz klienta";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(513, 627);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(31, 627);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(544, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 39);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Usuń z listy";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 685);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvProd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewOrder";
            this.Text = "Nowe zamówienie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProd;
    }
}