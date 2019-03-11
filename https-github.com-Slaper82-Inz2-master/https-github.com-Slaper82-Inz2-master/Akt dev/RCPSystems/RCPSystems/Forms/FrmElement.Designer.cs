namespace RCPSystems.Forms
{
    partial class FrmElement
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddElem = new System.Windows.Forms.Button();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSymOld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantOld = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddList = new System.Windows.Forms.Button();
            this.cmbElem = new System.Windows.Forms.ComboBox();
            this.btnPodElemeDel = new System.Windows.Forms.Button();
            this.dgvElem = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtSymOld);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtQuantOld);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnAddList);
            this.groupBox4.Controls.Add(this.cmbElem);
            this.groupBox4.Controls.Add(this.btnPodElemeDel);
            this.groupBox4.Controls.Add(this.dgvElem);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(29, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(875, 623);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wprowadź elementy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddElem);
            this.groupBox1.Controls.Add(this.txtQuan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSymbol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 503);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 100);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj nowy";
            // 
            // btnAddElem
            // 
            this.btnAddElem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddElem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddElem.Image = global::RCPSystems.Properties.Resources.Add1;
            this.btnAddElem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddElem.Location = new System.Drawing.Point(600, 43);
            this.btnAddElem.Name = "btnAddElem";
            this.btnAddElem.Size = new System.Drawing.Size(147, 36);
            this.btnAddElem.TabIndex = 22;
            this.btnAddElem.Text = "Dodaj";
            this.btnAddElem.UseVisualStyleBackColor = true;
            this.btnAddElem.Click += new System.EventHandler(this.btnAddElem_Click);
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(459, 52);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(100, 22);
            this.txtQuan.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ilość";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 22);
            this.txtName.TabIndex = 33;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(312, 52);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(100, 22);
            this.txtSymbol.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Symbol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Symbol";
            // 
            // txtSymOld
            // 
            this.txtSymOld.Location = new System.Drawing.Point(328, 449);
            this.txtSymOld.Name = "txtSymOld";
            this.txtSymOld.Size = new System.Drawing.Size(100, 22);
            this.txtSymOld.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ilość";
            // 
            // txtQuantOld
            // 
            this.txtQuantOld.Location = new System.Drawing.Point(475, 449);
            this.txtQuantOld.Name = "txtQuantOld";
            this.txtQuantOld.Size = new System.Drawing.Size(100, 22);
            this.txtQuantOld.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Wybierz z listy";
            // 
            // btnAddList
            // 
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddList.Image = global::RCPSystems.Properties.Resources.Add1;
            this.btnAddList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddList.Location = new System.Drawing.Point(616, 435);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(147, 36);
            this.btnAddList.TabIndex = 41;
            this.btnAddList.Text = "Dodaj";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // cmbElem
            // 
            this.cmbElem.FormattingEnabled = true;
            this.cmbElem.Location = new System.Drawing.Point(30, 447);
            this.cmbElem.Name = "cmbElem";
            this.cmbElem.Size = new System.Drawing.Size(247, 24);
            this.cmbElem.TabIndex = 40;
            this.cmbElem.SelectedIndexChanged += new System.EventHandler(this.cmbElem_SelectedIndexChanged);
            this.cmbElem.SelectedValueChanged += new System.EventHandler(this.cmbElem_SelectedValueChanged);
            // 
            // btnPodElemeDel
            // 
            this.btnPodElemeDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodElemeDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPodElemeDel.Image = global::RCPSystems.Properties.Resources.Delete;
            this.btnPodElemeDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPodElemeDel.Location = new System.Drawing.Point(616, 87);
            this.btnPodElemeDel.Name = "btnPodElemeDel";
            this.btnPodElemeDel.Size = new System.Drawing.Size(147, 36);
            this.btnPodElemeDel.TabIndex = 39;
            this.btnPodElemeDel.Text = "Usuń ";
            this.btnPodElemeDel.UseVisualStyleBackColor = true;
            this.btnPodElemeDel.Click += new System.EventHandler(this.btnPodElemeDel_Click);
            // 
            // dgvElem
            // 
            this.dgvElem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Symbol,
            this.ElementName,
            this.Quantity});
            this.dgvElem.Location = new System.Drawing.Point(16, 87);
            this.dgvElem.Name = "dgvElem";
            this.dgvElem.RowTemplate.Height = 24;
            this.dgvElem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElem.Size = new System.Drawing.Size(577, 296);
            this.dgvElem.TabIndex = 32;
            this.dgvElem.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvElem_RowStateChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Elementy";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Symbol
            // 
            this.Symbol.DataPropertyName = "Symbol";
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // ElementName
            // 
            this.ElementName.DataPropertyName = "Name";
            this.ElementName.HeaderText = "Nazwa elementu";
            this.ElementName.Name = "ElementName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Ilość";
            this.Quantity.Name = "Quantity";
            // 
            // FrmElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 669);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmElement";
            this.Text = "Dodaj element";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvElem;
        private System.Windows.Forms.Button btnAddElem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPodElemeDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSymOld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantOld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.ComboBox cmbElem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}