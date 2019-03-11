namespace RCPSystems
{
    partial class Harmo
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
            this.tvHarmo = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddHarmo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHarmoName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMon = new System.Windows.Forms.ComboBox();
            this.cmbTue = new System.Windows.Forms.ComboBox();
            this.cmbWed = new System.Windows.Forms.ComboBox();
            this.cmbThur = new System.Windows.Forms.ComboBox();
            this.cmbFri = new System.Windows.Forms.ComboBox();
            this.cmbSat = new System.Windows.Forms.ComboBox();
            this.cmbSun = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chbMonday = new System.Windows.Forms.CheckBox();
            this.chbTuesday = new System.Windows.Forms.CheckBox();
            this.chbWednesday = new System.Windows.Forms.CheckBox();
            this.chbThursday = new System.Windows.Forms.CheckBox();
            this.chbFriday = new System.Windows.Forms.CheckBox();
            this.chbSaturday = new System.Windows.Forms.CheckBox();
            this.chbSunday = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tvHarmo
            // 
            this.tvHarmo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvHarmo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tvHarmo.Location = new System.Drawing.Point(16, 20);
            this.tvHarmo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvHarmo.Name = "tvHarmo";
            this.tvHarmo.Size = new System.Drawing.Size(367, 652);
            this.tvHarmo.TabIndex = 0;
            this.tvHarmo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvHarmo_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(434, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Poniedziałek";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Image = global::RCPSystems.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(613, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 47);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Usuń ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddHarmo
            // 
            this.btnAddHarmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHarmo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddHarmo.Image = global::RCPSystems.Properties.Resources.Add1;
            this.btnAddHarmo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddHarmo.Location = new System.Drawing.Point(405, 21);
            this.btnAddHarmo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddHarmo.Name = "btnAddHarmo";
            this.btnAddHarmo.Size = new System.Drawing.Size(164, 47);
            this.btnAddHarmo.TabIndex = 10;
            this.btnAddHarmo.Text = "Dodaj";
            this.btnAddHarmo.UseVisualStyleBackColor = true;
            this.btnAddHarmo.Click += new System.EventHandler(this.btnAddHarmo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(434, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Wtorek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(434, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Środa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(434, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Czwartek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(434, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Piątek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(434, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sobota";
            // 
            // txtHarmoName
            // 
            this.txtHarmoName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHarmoName.Location = new System.Drawing.Point(643, 92);
            this.txtHarmoName.Name = "txtHarmoName";
            this.txtHarmoName.Size = new System.Drawing.Size(373, 30);
            this.txtHarmoName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(434, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nazwa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(434, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Niedziela";
            // 
            // cmbMon
            // 
            this.cmbMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMon.FormattingEnabled = true;
            this.cmbMon.Location = new System.Drawing.Point(643, 140);
            this.cmbMon.Name = "cmbMon";
            this.cmbMon.Size = new System.Drawing.Size(373, 31);
            this.cmbMon.TabIndex = 21;
            // 
            // cmbTue
            // 
            this.cmbTue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbTue.FormattingEnabled = true;
            this.cmbTue.Location = new System.Drawing.Point(643, 186);
            this.cmbTue.Name = "cmbTue";
            this.cmbTue.Size = new System.Drawing.Size(373, 31);
            this.cmbTue.TabIndex = 22;
            // 
            // cmbWed
            // 
            this.cmbWed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbWed.FormattingEnabled = true;
            this.cmbWed.Location = new System.Drawing.Point(643, 231);
            this.cmbWed.Name = "cmbWed";
            this.cmbWed.Size = new System.Drawing.Size(373, 31);
            this.cmbWed.TabIndex = 23;
            // 
            // cmbThur
            // 
            this.cmbThur.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbThur.FormattingEnabled = true;
            this.cmbThur.Location = new System.Drawing.Point(643, 278);
            this.cmbThur.Name = "cmbThur";
            this.cmbThur.Size = new System.Drawing.Size(373, 31);
            this.cmbThur.TabIndex = 24;
            // 
            // cmbFri
            // 
            this.cmbFri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFri.FormattingEnabled = true;
            this.cmbFri.Location = new System.Drawing.Point(643, 324);
            this.cmbFri.Name = "cmbFri";
            this.cmbFri.Size = new System.Drawing.Size(373, 31);
            this.cmbFri.TabIndex = 25;
            // 
            // cmbSat
            // 
            this.cmbSat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSat.FormattingEnabled = true;
            this.cmbSat.Location = new System.Drawing.Point(643, 372);
            this.cmbSat.Name = "cmbSat";
            this.cmbSat.Size = new System.Drawing.Size(373, 31);
            this.cmbSat.TabIndex = 26;
            // 
            // cmbSun
            // 
            this.cmbSun.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSun.FormattingEnabled = true;
            this.cmbSun.Location = new System.Drawing.Point(643, 418);
            this.cmbSun.Name = "cmbSun";
            this.cmbSun.Size = new System.Drawing.Size(373, 31);
            this.cmbSun.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::RCPSystems.Properties.Resources.Floppy2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(438, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 50);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Zapisz zmiany";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chbMonday
            // 
            this.chbMonday.AutoSize = true;
            this.chbMonday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbMonday.Location = new System.Drawing.Point(1121, 142);
            this.chbMonday.Name = "chbMonday";
            this.chbMonday.Size = new System.Drawing.Size(80, 27);
            this.chbMonday.TabIndex = 29;
            this.chbMonday.Text = "Wolne";
            this.chbMonday.UseVisualStyleBackColor = true;
            this.chbMonday.CheckedChanged += new System.EventHandler(this.chbMonday_CheckedChanged);
            // 
            // chbTuesday
            // 
            this.chbTuesday.AutoSize = true;
            this.chbTuesday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbTuesday.Location = new System.Drawing.Point(1121, 188);
            this.chbTuesday.Name = "chbTuesday";
            this.chbTuesday.Size = new System.Drawing.Size(80, 27);
            this.chbTuesday.TabIndex = 30;
            this.chbTuesday.Text = "Wolne";
            this.chbTuesday.UseVisualStyleBackColor = true;
            this.chbTuesday.CheckedChanged += new System.EventHandler(this.chbTuesday_CheckedChanged);
            // 
            // chbWednesday
            // 
            this.chbWednesday.AutoSize = true;
            this.chbWednesday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbWednesday.Location = new System.Drawing.Point(1121, 233);
            this.chbWednesday.Name = "chbWednesday";
            this.chbWednesday.Size = new System.Drawing.Size(80, 27);
            this.chbWednesday.TabIndex = 31;
            this.chbWednesday.Text = "Wolne";
            this.chbWednesday.UseVisualStyleBackColor = true;
            this.chbWednesday.CheckedChanged += new System.EventHandler(this.chbWednesday_CheckedChanged);
            // 
            // chbThursday
            // 
            this.chbThursday.AutoSize = true;
            this.chbThursday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbThursday.Location = new System.Drawing.Point(1121, 280);
            this.chbThursday.Name = "chbThursday";
            this.chbThursday.Size = new System.Drawing.Size(80, 27);
            this.chbThursday.TabIndex = 32;
            this.chbThursday.Text = "Wolne";
            this.chbThursday.UseVisualStyleBackColor = true;
            this.chbThursday.CheckedChanged += new System.EventHandler(this.chbThursday_CheckedChanged);
            // 
            // chbFriday
            // 
            this.chbFriday.AutoSize = true;
            this.chbFriday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbFriday.Location = new System.Drawing.Point(1121, 326);
            this.chbFriday.Name = "chbFriday";
            this.chbFriday.Size = new System.Drawing.Size(80, 27);
            this.chbFriday.TabIndex = 33;
            this.chbFriday.Text = "Wolne";
            this.chbFriday.UseVisualStyleBackColor = true;
            this.chbFriday.CheckedChanged += new System.EventHandler(this.chbFriday_CheckedChanged);
            // 
            // chbSaturday
            // 
            this.chbSaturday.AutoSize = true;
            this.chbSaturday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbSaturday.Location = new System.Drawing.Point(1121, 374);
            this.chbSaturday.Name = "chbSaturday";
            this.chbSaturday.Size = new System.Drawing.Size(80, 27);
            this.chbSaturday.TabIndex = 34;
            this.chbSaturday.Text = "Wolne";
            this.chbSaturday.UseVisualStyleBackColor = true;
            this.chbSaturday.CheckedChanged += new System.EventHandler(this.chbSaturday_CheckedChanged);
            // 
            // chbSunday
            // 
            this.chbSunday.AutoSize = true;
            this.chbSunday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbSunday.Location = new System.Drawing.Point(1121, 420);
            this.chbSunday.Name = "chbSunday";
            this.chbSunday.Size = new System.Drawing.Size(80, 27);
            this.chbSunday.TabIndex = 35;
            this.chbSunday.Text = "Wolne";
            this.chbSunday.UseVisualStyleBackColor = true;
            this.chbSunday.CheckedChanged += new System.EventHandler(this.chbSunday_CheckedChanged);
            // 
            // Harmo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 687);
            this.Controls.Add(this.chbSunday);
            this.Controls.Add(this.chbSaturday);
            this.Controls.Add(this.chbFriday);
            this.Controls.Add(this.chbThursday);
            this.Controls.Add(this.chbWednesday);
            this.Controls.Add(this.chbTuesday);
            this.Controls.Add(this.chbMonday);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSun);
            this.Controls.Add(this.cmbSat);
            this.Controls.Add(this.cmbFri);
            this.Controls.Add(this.cmbThur);
            this.Controls.Add(this.cmbWed);
            this.Controls.Add(this.cmbTue);
            this.Controls.Add(this.cmbMon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHarmoName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddHarmo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvHarmo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Harmo";
            this.Text = "Harmo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvHarmo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddHarmo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHarmoName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMon;
        private System.Windows.Forms.ComboBox cmbTue;
        private System.Windows.Forms.ComboBox cmbWed;
        private System.Windows.Forms.ComboBox cmbThur;
        private System.Windows.Forms.ComboBox cmbFri;
        private System.Windows.Forms.ComboBox cmbSat;
        private System.Windows.Forms.ComboBox cmbSun;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbMonday;
        private System.Windows.Forms.CheckBox chbTuesday;
        private System.Windows.Forms.CheckBox chbWednesday;
        private System.Windows.Forms.CheckBox chbThursday;
        private System.Windows.Forms.CheckBox chbFriday;
        private System.Windows.Forms.CheckBox chbSaturday;
        private System.Windows.Forms.CheckBox chbSunday;
    }
}