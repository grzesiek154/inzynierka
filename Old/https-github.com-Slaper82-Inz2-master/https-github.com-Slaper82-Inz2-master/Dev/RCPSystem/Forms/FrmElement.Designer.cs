namespace RCPSystem.Forms
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
            this.btnPodElemeDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvElem = new System.Windows.Forms.DataGridView();
            this.btnAddElem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPodElemeDel);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtSymbol);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.dgvElem);
            this.groupBox4.Controls.Add(this.btnAddElem);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtQuan);
            this.groupBox4.Location = new System.Drawing.Point(29, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(725, 522);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wprowadź elementy";
            // 
            // btnPodElemeDel
            // 
            this.btnPodElemeDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodElemeDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPodElemeDel.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnPodElemeDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPodElemeDel.Location = new System.Drawing.Point(541, 87);
            this.btnPodElemeDel.Name = "btnPodElemeDel";
            this.btnPodElemeDel.Size = new System.Drawing.Size(147, 36);
            this.btnPodElemeDel.TabIndex = 39;
            this.btnPodElemeDel.Text = "Usuń ";
            this.btnPodElemeDel.UseVisualStyleBackColor = true;
            this.btnPodElemeDel.Click += new System.EventHandler(this.btnPodElemeDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Symbol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nazwa";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(159, 448);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(100, 22);
            this.txtSymbol.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 448);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 33;
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
            this.dgvElem.Size = new System.Drawing.Size(506, 296);
            this.dgvElem.TabIndex = 32;
            this.dgvElem.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvElem_RowStateChanged);
            // 
            // btnAddElem
            // 
            this.btnAddElem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddElem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddElem.Image = global::RCPSystem.Properties.Resources.Add1;
            this.btnAddElem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddElem.Location = new System.Drawing.Point(541, 439);
            this.btnAddElem.Name = "btnAddElem";
            this.btnAddElem.Size = new System.Drawing.Size(147, 36);
            this.btnAddElem.TabIndex = 22;
            this.btnAddElem.Text = "Dodaj";
            this.btnAddElem.UseVisualStyleBackColor = true;
            this.btnAddElem.Click += new System.EventHandler(this.btnAddElem_Click);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ilość";
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(306, 448);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(100, 22);
            this.txtQuan.TabIndex = 27;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
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
            this.ClientSize = new System.Drawing.Size(936, 615);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmElement";
            this.Text = "Dodaj element";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}