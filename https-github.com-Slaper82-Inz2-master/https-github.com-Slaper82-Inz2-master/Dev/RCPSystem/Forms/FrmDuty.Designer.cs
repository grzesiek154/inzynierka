namespace RCPSystem.Forms
{
    partial class FrmDuty
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTyp = new System.Windows.Forms.DataGridView();
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.IdTypeL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DutyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTypeR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeNameR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lista zadań";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dodaj do listy zadań";
            // 
            // dgvTyp
            // 
            this.dgvTyp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTyp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTypeL,
            this.DutyName});
            this.dgvTyp.Location = new System.Drawing.Point(34, 62);
            this.dgvTyp.Name = "dgvTyp";
            this.dgvTyp.RowTemplate.Height = 24;
            this.dgvTyp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTyp.Size = new System.Drawing.Size(291, 464);
            this.dgvTyp.TabIndex = 20;
            this.dgvTyp.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvTyp_RowStateChanged);
            // 
            // dgvSelected
            // 
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTypeR,
            this.TypeNameR});
            this.dgvSelected.Location = new System.Drawing.Point(600, 62);
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.RowTemplate.Height = 24;
            this.dgvSelected.Size = new System.Drawing.Size(302, 464);
            this.dgvSelected.TabIndex = 21;
            this.dgvSelected.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvSelected_RowStateChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(391, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 29);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(391, 211);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(127, 29);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // IdTypeL
            // 
            this.IdTypeL.DataPropertyName = "IdType";
            this.IdTypeL.HeaderText = "Id";
            this.IdTypeL.Name = "IdTypeL";
            // 
            // DutyName
            // 
            this.DutyName.DataPropertyName = "TypeName";
            this.DutyName.HeaderText = "Nazwa";
            this.DutyName.Name = "DutyName";
            // 
            // IdTypeR
            // 
            this.IdTypeR.DataPropertyName = "IdType";
            this.IdTypeR.HeaderText = "Id";
            this.IdTypeR.Name = "IdTypeR";
            // 
            // TypeNameR
            // 
            this.TypeNameR.DataPropertyName = "TypeName";
            this.TypeNameR.HeaderText = "Nazwa";
            this.TypeNameR.Name = "TypeNameR";
            // 
            // FrmDuty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 606);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTyp);
            this.Name = "FrmDuty";
            this.Text = "FrmDuty";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTyp;
        private System.Windows.Forms.DataGridView dgvSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTypeL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DutyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTypeR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeNameR;
    }
}