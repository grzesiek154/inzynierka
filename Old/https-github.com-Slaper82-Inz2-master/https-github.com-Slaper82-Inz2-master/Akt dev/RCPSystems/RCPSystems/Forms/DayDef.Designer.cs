namespace RCPSystems
{
    partial class DayDef
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
            this.tvDay = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbStart = new System.Windows.Forms.GroupBox();
            this.txtBreak = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEarly = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLate = new System.Windows.Forms.TextBox();
            this.mtxtStart = new System.Windows.Forms.MaskedTextBox();
            this.gbStop = new System.Windows.Forms.GroupBox();
            this.txtEndLate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndEarly = new System.Windows.Forms.TextBox();
            this.mtxtEnd = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbStart.SuspendLayout();
            this.gbStop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDay
            // 
            this.tvDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tvDay.Location = new System.Drawing.Point(16, 21);
            this.tvDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvDay.Name = "tvDay";
            this.tvDay.Size = new System.Drawing.Size(367, 978);
            this.tvDay.TabIndex = 0;
            this.tvDay.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDay_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Godzina rozpoczęcia pracy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dozwolone spóźnienie(min)";
            // 
            // gbStart
            // 
            this.gbStart.Controls.Add(this.txtBreak);
            this.gbStart.Controls.Add(this.label8);
            this.gbStart.Controls.Add(this.txtEarly);
            this.gbStart.Controls.Add(this.label4);
            this.gbStart.Controls.Add(this.txtLate);
            this.gbStart.Controls.Add(this.mtxtStart);
            this.gbStart.Controls.Add(this.label1);
            this.gbStart.Controls.Add(this.label2);
            this.gbStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbStart.Location = new System.Drawing.Point(395, 174);
            this.gbStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStart.Name = "gbStart";
            this.gbStart.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStart.Size = new System.Drawing.Size(1076, 205);
            this.gbStart.TabIndex = 3;
            this.gbStart.TabStop = false;
            this.gbStart.Text = "Definicja rozpoczęcia pracy";
            // 
            // txtBreak
            // 
            this.txtBreak.Location = new System.Drawing.Point(381, 161);
            this.txtBreak.Name = "txtBreak";
            this.txtBreak.Size = new System.Drawing.Size(59, 30);
            this.txtBreak.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Długość przerwy(min)";
            // 
            // txtEarly
            // 
            this.txtEarly.Location = new System.Drawing.Point(381, 119);
            this.txtEarly.Name = "txtEarly";
            this.txtEarly.Size = new System.Drawing.Size(59, 30);
            this.txtEarly.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dozwolone przyjście wcześniej (min)";
            // 
            // txtLate
            // 
            this.txtLate.Location = new System.Drawing.Point(381, 79);
            this.txtLate.Name = "txtLate";
            this.txtLate.Size = new System.Drawing.Size(59, 30);
            this.txtLate.TabIndex = 4;
            // 
            // mtxtStart
            // 
            this.mtxtStart.Location = new System.Drawing.Point(381, 39);
            this.mtxtStart.Mask = "00:00";
            this.mtxtStart.Name = "mtxtStart";
            this.mtxtStart.Size = new System.Drawing.Size(59, 30);
            this.mtxtStart.TabIndex = 3;
            this.mtxtStart.Text = "0000";
            this.mtxtStart.ValidatingType = typeof(System.DateTime);
            // 
            // gbStop
            // 
            this.gbStop.Controls.Add(this.txtEndLate);
            this.gbStop.Controls.Add(this.label5);
            this.gbStop.Controls.Add(this.txtEndEarly);
            this.gbStop.Controls.Add(this.mtxtEnd);
            this.gbStop.Controls.Add(this.label6);
            this.gbStop.Controls.Add(this.label7);
            this.gbStop.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbStop.Location = new System.Drawing.Point(395, 402);
            this.gbStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStop.Name = "gbStop";
            this.gbStop.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStop.Size = new System.Drawing.Size(1076, 161);
            this.gbStop.TabIndex = 4;
            this.gbStop.TabStop = false;
            this.gbStop.Text = "Definicja zakończenia pracy";
            // 
            // txtEndLate
            // 
            this.txtEndLate.Location = new System.Drawing.Point(381, 118);
            this.txtEndLate.Name = "txtEndLate";
            this.txtEndLate.Size = new System.Drawing.Size(59, 30);
            this.txtEndLate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dozwolone wyjście później(min)";
            // 
            // txtEndEarly
            // 
            this.txtEndEarly.Location = new System.Drawing.Point(381, 75);
            this.txtEndEarly.Name = "txtEndEarly";
            this.txtEndEarly.Size = new System.Drawing.Size(59, 30);
            this.txtEndEarly.TabIndex = 10;
            // 
            // mtxtEnd
            // 
            this.mtxtEnd.Location = new System.Drawing.Point(381, 35);
            this.mtxtEnd.Mask = "00:00";
            this.mtxtEnd.Name = "mtxtEnd";
            this.mtxtEnd.Size = new System.Drawing.Size(59, 30);
            this.mtxtEnd.TabIndex = 9;
            this.mtxtEnd.Text = "0000";
            this.mtxtEnd.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Godzina zakończenia pracy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dozwolone wyjście wcześniej(min)";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(390, 132);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(473, 30);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(390, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwa dniówki";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Image = global::RCPSystems.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(609, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 47);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Usuń ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddUser.Image = global::RCPSystems.Properties.Resources.Add1;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(405, 21);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(185, 47);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Dodaj";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::RCPSystems.Properties.Resources.Floppy2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1193, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 71);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DayDef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 1027);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gbStop);
            this.Controls.Add(this.gbStart);
            this.Controls.Add(this.tvDay);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DayDef";
            this.Text = "Definicja dniówek";
            this.gbStart.ResumeLayout(false);
            this.gbStart.PerformLayout();
            this.gbStop.ResumeLayout(false);
            this.gbStop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbStart;
        private System.Windows.Forms.GroupBox gbStop;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.MaskedTextBox mtxtStart;
        private System.Windows.Forms.TextBox txtEarly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLate;
        private System.Windows.Forms.TextBox txtEndLate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndEarly;
        private System.Windows.Forms.MaskedTextBox mtxtEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBreak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
    }
}