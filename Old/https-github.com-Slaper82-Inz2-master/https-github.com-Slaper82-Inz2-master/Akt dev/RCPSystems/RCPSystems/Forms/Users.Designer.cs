namespace RCPSystems
{
    partial class Users
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.tvUser = new System.Windows.Forms.TreeView();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnObowAdd = new System.Windows.Forms.Button();
            this.cmbObow = new System.Windows.Forms.ComboBox();
            this.mtxtPost = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.TreeImages = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvDuty = new System.Windows.Forms.DataGridView();
            this.IdDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).BeginInit();
            this.SuspendLayout();
            // 
            // tvUser
            // 
            this.tvUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tvUser.Location = new System.Drawing.Point(16, 21);
            this.tvUser.Name = "tvUser";
            this.tvUser.Size = new System.Drawing.Size(367, 831);
            this.tvUser.TabIndex = 0;
            this.tvUser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvUser_AfterSelect);
            // 
            // gbUser
            // 
            this.gbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUser.Controls.Add(this.dgvDuty);
            this.gbUser.Controls.Add(this.btnDel);
            this.gbUser.Controls.Add(this.label10);
            this.gbUser.Controls.Add(this.cmbGender);
            this.gbUser.Controls.Add(this.label9);
            this.gbUser.Controls.Add(this.btnSave);
            this.gbUser.Controls.Add(this.cmbDept);
            this.gbUser.Controls.Add(this.label8);
            this.gbUser.Controls.Add(this.btnObowAdd);
            this.gbUser.Controls.Add(this.cmbObow);
            this.gbUser.Controls.Add(this.mtxtPost);
            this.gbUser.Controls.Add(this.dtpBirthDate);
            this.gbUser.Controls.Add(this.txtCity);
            this.gbUser.Controls.Add(this.txtAddress);
            this.gbUser.Controls.Add(this.txtSurname);
            this.gbUser.Controls.Add(this.label7);
            this.gbUser.Controls.Add(this.label6);
            this.gbUser.Controls.Add(this.label5);
            this.gbUser.Controls.Add(this.label4);
            this.gbUser.Controls.Add(this.label3);
            this.gbUser.Controls.Add(this.label2);
            this.gbUser.Controls.Add(this.txtBirthPlace);
            this.gbUser.Controls.Add(this.txtName);
            this.gbUser.Controls.Add(this.label1);
            this.gbUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbUser.Location = new System.Drawing.Point(405, 128);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(1289, 724);
            this.gbUser.TabIndex = 1;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Dane pracownika";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Mężczyzna",
            "Kobieta"});
            this.cmbGender.Location = new System.Drawing.Point(560, 140);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(192, 31);
            this.cmbGender.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(16, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Wybierz dział firmy";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::RCPSystems.Properties.Resources.Floppy2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1022, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 71);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(272, 285);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(480, 31);
            this.cmbDept.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(555, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Płeć";
            // 
            // btnObowAdd
            // 
            this.btnObowAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObowAdd.Location = new System.Drawing.Point(891, 366);
            this.btnObowAdd.Name = "btnObowAdd";
            this.btnObowAdd.Size = new System.Drawing.Size(150, 45);
            this.btnObowAdd.TabIndex = 18;
            this.btnObowAdd.Text = "Dodaj";
            this.btnObowAdd.UseVisualStyleBackColor = true;
            this.btnObowAdd.Click += new System.EventHandler(this.btnObowAdd_Click);
            // 
            // cmbObow
            // 
            this.cmbObow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbObow.FormattingEnabled = true;
            this.cmbObow.Location = new System.Drawing.Point(560, 366);
            this.cmbObow.Name = "cmbObow";
            this.cmbObow.Size = new System.Drawing.Size(241, 31);
            this.cmbObow.TabIndex = 17;
            // 
            // mtxtPost
            // 
            this.mtxtPost.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtxtPost.Location = new System.Drawing.Point(294, 218);
            this.mtxtPost.Name = "mtxtPost";
            this.mtxtPost.Size = new System.Drawing.Size(200, 30);
            this.mtxtPost.TabIndex = 15;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(294, 140);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 30);
            this.dtpBirthDate.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCity.Location = new System.Drawing.Point(560, 67);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(192, 30);
            this.txtCity.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAddress.Location = new System.Drawing.Point(16, 219);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(194, 30);
            this.txtAddress.TabIndex = 11;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSurname.Location = new System.Drawing.Point(296, 67);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(198, 30);
            this.txtSurname.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(555, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Miasto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(298, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kod pocztowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(291, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miejsce urodzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(291, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBirthPlace.Location = new System.Drawing.Point(16, 142);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(194, 30);
            this.txtBirthPlace.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(18, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 30);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Image = global::RCPSystems.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(586, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 47);
            this.btnDelete.TabIndex = 4;
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
            this.btnAddUser.Size = new System.Drawing.Size(148, 47);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Dodaj";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // TreeImages
            // 
            this.TreeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImages.ImageStream")));
            this.TreeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeImages.Images.SetKeyName(0, "Home.png");
            this.TreeImages.Images.SetKeyName(1, "User.png");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(16, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Obowiązki pracownika:";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDel.Location = new System.Drawing.Point(891, 426);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(150, 45);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "Usuń";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvDuty
            // 
            this.dgvDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDuty});
            this.dgvDuty.Location = new System.Drawing.Point(18, 366);
            this.dgvDuty.Name = "dgvDuty";
            this.dgvDuty.RowTemplate.Height = 24;
            this.dgvDuty.Size = new System.Drawing.Size(441, 210);
            this.dgvDuty.TabIndex = 28;
            this.dgvDuty.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvDuty_RowStateChanged);
            // 
            // IdDuty
            // 
            this.IdDuty.DataPropertyName = "IdDuty";
            this.IdDuty.HeaderText = "IdDuty";
            this.IdDuty.Name = "IdDuty";
            this.IdDuty.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1937, 864);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.tvUser);
            this.Name = "Users";
            this.Text = "Użytkownicy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_FormClosed);
            this.Load += new System.EventHandler(this.Users_Load);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvUser;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtPost;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnObowAdd;
        private System.Windows.Forms.ComboBox cmbObow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ImageList TreeImages;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDuty;
    }
}