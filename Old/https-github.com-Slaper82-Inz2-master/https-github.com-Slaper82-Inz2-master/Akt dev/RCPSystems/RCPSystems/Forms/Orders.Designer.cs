namespace RCPSystems.Forms
{
    partial class Orders
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.IdZam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utworzono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdZam,
            this.Utworzono,
            this.Names,
            this.Opis,
            this.CLientID,
            this.Done});
            this.dgvOrders.Location = new System.Drawing.Point(12, 95);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1696, 485);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvOrders_RowStateChanged);
            // 
            // IdZam
            // 
            this.IdZam.DataPropertyName = "IdZamowienia";
            this.IdZam.HeaderText = "Numer zamówienia";
            this.IdZam.Name = "IdZam";
            // 
            // Utworzono
            // 
            this.Utworzono.DataPropertyName = "Utworzono";
            this.Utworzono.HeaderText = "Utworzone";
            this.Utworzono.Name = "Utworzono";
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Names";
            this.Names.HeaderText = "Kto utworzył";
            this.Names.Name = "Names";
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            // 
            // CLientID
            // 
            this.CLientID.DataPropertyName = "Klient";
            this.CLientID.HeaderText = "Nazwa klienta";
            this.CLientID.Name = "CLientID";
            // 
            // Done
            // 
            this.Done.DataPropertyName = "Done";
            this.Done.HeaderText = "Zrealizowane";
            this.Done.Name = "Done";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(12, 30);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(150, 50);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Nowe zamówienie";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Location = new System.Drawing.Point(1558, 30);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(150, 50);
            this.btnDelOrder.TabIndex = 2;
            this.btnDelOrder.Text = "Usuń";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(1390, 30);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(150, 50);
            this.btnEditOrder.TabIndex = 3;
            this.btnEditOrder.Text = "Edytuj";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(201, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 50);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 616);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dgvOrders);
            this.Name = "Orders";
            this.Text = "Zamówienia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utworzono;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Done;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.Button btnRefresh;
    }
}