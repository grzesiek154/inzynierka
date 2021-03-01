namespace RCPSystems.Forms
{
    partial class FrmElements
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.dgvElems = new System.Windows.Forms.DataGridView();
            this.IdElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(119, 371);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(190, 58);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Wybierz zaznaczony element";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // dgvElems
            // 
            this.dgvElems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdElement,
            this.ElemName,
            this.Symbol});
            this.dgvElems.Location = new System.Drawing.Point(26, 50);
            this.dgvElems.Name = "dgvElems";
            this.dgvElems.RowTemplate.Height = 24;
            this.dgvElems.Size = new System.Drawing.Size(435, 260);
            this.dgvElems.TabIndex = 2;
            this.dgvElems.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvElems_RowStateChanged);
            // 
            // IdElement
            // 
            this.IdElement.DataPropertyName = "IdElement";
            this.IdElement.HeaderText = "Id";
            this.IdElement.Name = "IdElement";
            this.IdElement.Visible = false;
            // 
            // ElemName
            // 
            this.ElemName.DataPropertyName = "Name";
            this.ElemName.HeaderText = "Nazwa";
            this.ElemName.Name = "ElemName";
            // 
            // Symbol
            // 
            this.Symbol.DataPropertyName = "Symbol";
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // FrmElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 498);
            this.Controls.Add(this.dgvElems);
            this.Controls.Add(this.btnChoose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmElements";
            this.Text = "Wybierz element";
            ((System.ComponentModel.ISupportInitialize)(this.dgvElems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DataGridView dgvElems;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
    }
}