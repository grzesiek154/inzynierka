namespace RCPSystems
{
    partial class TimeAttandance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeAttandance));
            this.tvUsers = new System.Windows.Forms.TreeView();
            this.tcTimeAtt = new System.Windows.Forms.TabControl();
            this.tHarmo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHarChose = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvUserHarmo = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Do = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTransactions = new System.Windows.Forms.TabPage();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.lp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPairs = new System.Windows.Forms.TabPage();
            this.dgvTranPairs = new System.Windows.Forms.DataGridView();
            this.NazwaIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poczatek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koniec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTimeBreak = new System.Windows.Forms.DataGridView();
            this.NazwaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoczatekB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoniecB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TreeImages = new System.Windows.Forms.ImageList(this.components);
            this.btnCount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNadgodziny = new System.Windows.Forms.Label();
            this.lblBraki = new System.Windows.Forms.Label();
            this.lblNorma = new System.Windows.Forms.Label();
            this.lblOdczytane = new System.Windows.Forms.Label();
            this.UserRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odczytane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Przerwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Braki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nadgodziny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transakcje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvZad = new System.Windows.Forms.DataGridView();
            this.btnHarmoAdd = new System.Windows.Forms.Button();
            this.btnHarmoDel = new System.Windows.Forms.Button();
            this.UserZad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameZad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Czaspracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcTimeAtt.SuspendLayout();
            this.tHarmo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserHarmo)).BeginInit();
            this.tTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.tPairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranPairs)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeBreak)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZad)).BeginInit();
            this.SuspendLayout();
            // 
            // tvUsers
            // 
            this.tvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvUsers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tvUsers.Location = new System.Drawing.Point(16, 226);
            this.tvUsers.Name = "tvUsers";
            this.tvUsers.Size = new System.Drawing.Size(325, 587);
            this.tvUsers.TabIndex = 0;
            this.tvUsers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvUsers_AfterSelect);
            // 
            // tcTimeAtt
            // 
            this.tcTimeAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTimeAtt.Controls.Add(this.tHarmo);
            this.tcTimeAtt.Controls.Add(this.tTransactions);
            this.tcTimeAtt.Controls.Add(this.tPairs);
            this.tcTimeAtt.Controls.Add(this.tabPage1);
            this.tcTimeAtt.Controls.Add(this.tabPage2);
            this.tcTimeAtt.Controls.Add(this.tabPage3);
            this.tcTimeAtt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcTimeAtt.Location = new System.Drawing.Point(369, 230);
            this.tcTimeAtt.Name = "tcTimeAtt";
            this.tcTimeAtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcTimeAtt.SelectedIndex = 0;
            this.tcTimeAtt.Size = new System.Drawing.Size(1471, 583);
            this.tcTimeAtt.TabIndex = 1;
            // 
            // tHarmo
            // 
            this.tHarmo.Controls.Add(this.groupBox1);
            this.tHarmo.Controls.Add(this.btnHarmoDel);
            this.tHarmo.Controls.Add(this.dgvUserHarmo);
            this.tHarmo.Location = new System.Drawing.Point(4, 32);
            this.tHarmo.Name = "tHarmo";
            this.tHarmo.Padding = new System.Windows.Forms.Padding(3);
            this.tHarmo.Size = new System.Drawing.Size(1463, 547);
            this.tHarmo.TabIndex = 0;
            this.tHarmo.Text = "Harmonogram";
            this.tHarmo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHarChose);
            this.groupBox1.Controls.Add(this.btnHarmoAdd);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Location = new System.Drawing.Point(31, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 101);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wstaw harmonogram";
            // 
            // cmbHarChose
            // 
            this.cmbHarChose.FormattingEnabled = true;
            this.cmbHarChose.Location = new System.Drawing.Point(33, 36);
            this.cmbHarChose.Name = "cmbHarChose";
            this.cmbHarChose.Size = new System.Drawing.Size(181, 31);
            this.cmbHarChose.TabIndex = 23;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(450, 36);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(141, 30);
            this.dtpTo.TabIndex = 25;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(265, 36);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(146, 30);
            this.dtpFrom.TabIndex = 24;
            // 
            // dgvUserHarmo
            // 
            this.dgvUserHarmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserHarmo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.Od,
            this.Do,
            this.Id});
            this.dgvUserHarmo.Location = new System.Drawing.Point(31, 143);
            this.dgvUserHarmo.Name = "dgvUserHarmo";
            this.dgvUserHarmo.RowTemplate.Height = 24;
            this.dgvUserHarmo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserHarmo.Size = new System.Drawing.Size(786, 397);
            this.dgvUserHarmo.TabIndex = 0;
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            // 
            // Od
            // 
            this.Od.DataPropertyName = "Od";
            this.Od.HeaderText = "Ważny od";
            this.Od.Name = "Od";
            // 
            // Do
            // 
            this.Do.DataPropertyName = "Do";
            this.Do.HeaderText = "Ważny do";
            this.Do.Name = "Do";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // tTransactions
            // 
            this.tTransactions.Controls.Add(this.dgvTransactions);
            this.tTransactions.Location = new System.Drawing.Point(4, 32);
            this.tTransactions.Name = "tTransactions";
            this.tTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tTransactions.Size = new System.Drawing.Size(1463, 547);
            this.tTransactions.TabIndex = 1;
            this.tTransactions.Text = "Transakcje";
            this.tTransactions.UseVisualStyleBackColor = true;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lp,
            this.TranId,
            this.Date,
            this.Tran,
            this.User});
            this.dgvTransactions.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvTransactions.Location = new System.Drawing.Point(23, 20);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(893, 521);
            this.dgvTransactions.TabIndex = 0;
            this.dgvTransactions.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTransactions_RowPostPaint);
            // 
            // lp
            // 
            this.lp.DataPropertyName = "(none)";
            this.lp.HeaderText = "Lp";
            this.lp.Name = "lp";
            this.lp.Width = 50;
            // 
            // TranId
            // 
            this.TranId.DataPropertyName = "Id";
            this.TranId.HeaderText = "Id";
            this.TranId.Name = "TranId";
            this.TranId.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Data";
            this.Date.HeaderText = "Data transakcji";
            this.Date.Name = "Date";
            this.Date.Width = 200;
            // 
            // Tran
            // 
            this.Tran.DataPropertyName = "Typ_Transakcji";
            this.Tran.HeaderText = "Typ transakcji";
            this.Tran.Name = "Tran";
            this.Tran.Width = 200;
            // 
            // User
            // 
            this.User.DataPropertyName = "Nazwa_uzytkownika";
            this.User.HeaderText = "Użytkownik";
            this.User.Name = "User";
            this.User.Width = 400;
            // 
            // tPairs
            // 
            this.tPairs.Controls.Add(this.dgvTranPairs);
            this.tPairs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tPairs.Location = new System.Drawing.Point(4, 32);
            this.tPairs.Name = "tPairs";
            this.tPairs.Padding = new System.Windows.Forms.Padding(3);
            this.tPairs.Size = new System.Drawing.Size(1463, 547);
            this.tPairs.TabIndex = 2;
            this.tPairs.Text = "Pary transakcji";
            this.tPairs.UseVisualStyleBackColor = true;
            // 
            // dgvTranPairs
            // 
            this.dgvTranPairs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTranPairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranPairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazwaIO,
            this.Poczatek,
            this.Koniec});
            this.dgvTranPairs.Location = new System.Drawing.Point(25, 23);
            this.dgvTranPairs.Name = "dgvTranPairs";
            this.dgvTranPairs.RowTemplate.Height = 24;
            this.dgvTranPairs.Size = new System.Drawing.Size(983, 518);
            this.dgvTranPairs.TabIndex = 0;
            // 
            // NazwaIO
            // 
            this.NazwaIO.DataPropertyName = "Nazwa";
            this.NazwaIO.HeaderText = "Nazwa";
            this.NazwaIO.Name = "NazwaIO";
            // 
            // Poczatek
            // 
            this.Poczatek.DataPropertyName = "Poczatek";
            this.Poczatek.HeaderText = "Początek pracy";
            this.Poczatek.Name = "Poczatek";
            // 
            // Koniec
            // 
            this.Koniec.DataPropertyName = "Koniec";
            this.Koniec.HeaderText = "Koniec pracy";
            this.Koniec.Name = "Koniec";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTimeBreak);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1463, 547);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Pary przerw";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTimeBreak
            // 
            this.dgvTimeBreak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTimeBreak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeBreak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazwaB,
            this.PoczatekB,
            this.KoniecB});
            this.dgvTimeBreak.Location = new System.Drawing.Point(16, 23);
            this.dgvTimeBreak.Name = "dgvTimeBreak";
            this.dgvTimeBreak.RowTemplate.Height = 24;
            this.dgvTimeBreak.Size = new System.Drawing.Size(983, 518);
            this.dgvTimeBreak.TabIndex = 1;
            // 
            // NazwaB
            // 
            this.NazwaB.DataPropertyName = "Nazwa";
            this.NazwaB.HeaderText = "Nazwa";
            this.NazwaB.Name = "NazwaB";
            // 
            // PoczatekB
            // 
            this.PoczatekB.DataPropertyName = "Poczatek";
            this.PoczatekB.HeaderText = "Początek przerwy";
            this.PoczatekB.Name = "PoczatekB";
            // 
            // KoniecB
            // 
            this.KoniecB.DataPropertyName = "Koniec";
            this.KoniecB.HeaderText = "Koniec przerwy";
            this.KoniecB.Name = "KoniecB";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1463, 547);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Raport czasu pracy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserRap,
            this.Data,
            this.Norma,
            this.Odczytane,
            this.Przerwa,
            this.Braki,
            this.Nadgodziny,
            this.Transakcje});
            this.dgvReport.Location = new System.Drawing.Point(15, 12);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1155, 529);
            this.dgvReport.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvZad);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1463, 547);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Raport czasu zadań";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.btnEnd);
            this.gbTime.Controls.Add(this.btnBegin);
            this.gbTime.Controls.Add(this.dtpStop);
            this.gbTime.Controls.Add(this.dtpStart);
            this.gbTime.Controls.Add(this.label2);
            this.gbTime.Controls.Add(this.label1);
            this.gbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTime.Location = new System.Drawing.Point(16, 29);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(531, 178);
            this.gbTime.TabIndex = 2;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Zakres raportu";
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnd.Location = new System.Drawing.Point(298, 116);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(188, 34);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "Koniec okresu";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBegin.Location = new System.Drawing.Point(298, 55);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(188, 34);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "Początek okresu";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // dtpStop
            // 
            this.dtpStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStop.Location = new System.Drawing.Point(12, 116);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(261, 34);
            this.dtpStop.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(10, 55);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(263, 34);
            this.dtpStart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koniec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Początek";
            // 
            // TreeImages
            // 
            this.TreeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImages.ImageStream")));
            this.TreeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeImages.Images.SetKeyName(0, "Clock.png");
            this.TreeImages.Images.SetKeyName(1, "Chat.png");
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(614, 85);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(158, 45);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Przelicz";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Czas pracy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Norma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Braki:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nadgodziny:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNadgodziny);
            this.groupBox2.Controls.Add(this.lblBraki);
            this.groupBox2.Controls.Add(this.lblNorma);
            this.groupBox2.Controls.Add(this.lblOdczytane);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(831, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podsumowanie";
            // 
            // lblNadgodziny
            // 
            this.lblNadgodziny.AutoSize = true;
            this.lblNadgodziny.Location = new System.Drawing.Point(325, 82);
            this.lblNadgodziny.Name = "lblNadgodziny";
            this.lblNadgodziny.Size = new System.Drawing.Size(44, 17);
            this.lblNadgodziny.TabIndex = 8;
            this.lblNadgodziny.Text = "00:00";
            // 
            // lblBraki
            // 
            this.lblBraki.AutoSize = true;
            this.lblBraki.Location = new System.Drawing.Point(325, 37);
            this.lblBraki.Name = "lblBraki";
            this.lblBraki.Size = new System.Drawing.Size(44, 17);
            this.lblBraki.TabIndex = 11;
            this.lblBraki.Text = "00:00";
            // 
            // lblNorma
            // 
            this.lblNorma.AutoSize = true;
            this.lblNorma.Location = new System.Drawing.Point(130, 82);
            this.lblNorma.Name = "lblNorma";
            this.lblNorma.Size = new System.Drawing.Size(44, 17);
            this.lblNorma.TabIndex = 10;
            this.lblNorma.Text = "00:00";
            // 
            // lblOdczytane
            // 
            this.lblOdczytane.AutoSize = true;
            this.lblOdczytane.Location = new System.Drawing.Point(130, 37);
            this.lblOdczytane.Name = "lblOdczytane";
            this.lblOdczytane.Size = new System.Drawing.Size(44, 17);
            this.lblOdczytane.TabIndex = 9;
            this.lblOdczytane.Text = "00:00";
            // 
            // UserRap
            // 
            this.UserRap.DataPropertyName = "User";
            this.UserRap.HeaderText = "Użytkownik";
            this.UserRap.Name = "UserRap";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Norma
            // 
            this.Norma.DataPropertyName = "Norma";
            this.Norma.HeaderText = "Norma czasu (h)";
            this.Norma.Name = "Norma";
            this.Norma.Width = 170;
            // 
            // Odczytane
            // 
            this.Odczytane.DataPropertyName = "Odczytane";
            this.Odczytane.HeaderText = "Odczytany czas";
            this.Odczytane.Name = "Odczytane";
            this.Odczytane.Width = 200;
            // 
            // Przerwa
            // 
            this.Przerwa.DataPropertyName = "Przerwa";
            this.Przerwa.HeaderText = "Przerwa (min)";
            this.Przerwa.Name = "Przerwa";
            this.Przerwa.Width = 150;
            // 
            // Braki
            // 
            this.Braki.DataPropertyName = "Braki";
            this.Braki.HeaderText = "Braki (h)";
            this.Braki.Name = "Braki";
            this.Braki.Width = 150;
            // 
            // Nadgodziny
            // 
            this.Nadgodziny.DataPropertyName = "Nadgodziny";
            this.Nadgodziny.HeaderText = "Nadgodziny (h)";
            this.Nadgodziny.Name = "Nadgodziny";
            this.Nadgodziny.Width = 170;
            // 
            // Transakcje
            // 
            this.Transakcje.DataPropertyName = "Transakcje";
            this.Transakcje.HeaderText = "Transakcje";
            this.Transakcje.Name = "Transakcje";
            // 
            // dgvZad
            // 
            this.dgvZad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserZad,
            this.NameZad,
            this.Ilosc,
            this.Czaspracy});
            this.dgvZad.Location = new System.Drawing.Point(26, 24);
            this.dgvZad.Name = "dgvZad";
            this.dgvZad.RowTemplate.Height = 24;
            this.dgvZad.Size = new System.Drawing.Size(828, 504);
            this.dgvZad.TabIndex = 0;
            // 
            // btnHarmoAdd
            // 
            this.btnHarmoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarmoAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHarmoAdd.Image = global::RCPSystems.Properties.Resources.Add1;
            this.btnHarmoAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHarmoAdd.Location = new System.Drawing.Point(649, 36);
            this.btnHarmoAdd.Name = "btnHarmoAdd";
            this.btnHarmoAdd.Size = new System.Drawing.Size(147, 36);
            this.btnHarmoAdd.TabIndex = 20;
            this.btnHarmoAdd.Text = "Dodaj";
            this.btnHarmoAdd.UseVisualStyleBackColor = true;
            this.btnHarmoAdd.Click += new System.EventHandler(this.btnHarmoAdd_Click);
            // 
            // btnHarmoDel
            // 
            this.btnHarmoDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarmoDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHarmoDel.Image = global::RCPSystems.Properties.Resources.Delete;
            this.btnHarmoDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHarmoDel.Location = new System.Drawing.Point(872, 613);
            this.btnHarmoDel.Name = "btnHarmoDel";
            this.btnHarmoDel.Size = new System.Drawing.Size(147, 36);
            this.btnHarmoDel.TabIndex = 22;
            this.btnHarmoDel.Text = "Usuń ";
            this.btnHarmoDel.UseVisualStyleBackColor = true;
            this.btnHarmoDel.Click += new System.EventHandler(this.btnHarmoDel_Click);
            // 
            // UserZad
            // 
            this.UserZad.DataPropertyName = "User";
            this.UserZad.HeaderText = "Użytkownik";
            this.UserZad.Name = "UserZad";
            // 
            // NameZad
            // 
            this.NameZad.DataPropertyName = "Name";
            this.NameZad.HeaderText = "Nazwa elementu";
            this.NameZad.Name = "NameZad";
            this.NameZad.Width = 200;
            // 
            // Ilosc
            // 
            this.Ilosc.DataPropertyName = "Ilosc";
            this.Ilosc.HeaderText = "Ilość";
            this.Ilosc.Name = "Ilosc";
            // 
            // Czaspracy
            // 
            this.Czaspracy.DataPropertyName = "Czaspracy";
            this.Czaspracy.HeaderText = "Czas wykonania (h)";
            this.Czaspracy.Name = "Czaspracy";
            this.Czaspracy.Width = 200;
            // 
            // TimeAttandance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 825);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.tcTimeAtt);
            this.Controls.Add(this.tvUsers);
            this.Name = "TimeAttandance";
            this.Text = "Czas pracy i raporty";
            this.tcTimeAtt.ResumeLayout(false);
            this.tHarmo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserHarmo)).EndInit();
            this.tTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.tPairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranPairs)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeBreak)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvUsers;
        private System.Windows.Forms.TabControl tcTimeAtt;
        private System.Windows.Forms.TabPage tHarmo;
        private System.Windows.Forms.TabPage tTransactions;
        private System.Windows.Forms.TabPage tPairs;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.DataGridView dgvUserHarmo;
        private System.Windows.Forms.Button btnHarmoAdd;
        private System.Windows.Forms.Button btnHarmoDel;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cmbHarChose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tran;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridView dgvTranPairs;
        private System.Windows.Forms.ImageList TreeImages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridView dgvTimeBreak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Od;
        private System.Windows.Forms.DataGridViewTextBoxColumn Do;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poczatek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koniec;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoczatekB;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoniecB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNadgodziny;
        private System.Windows.Forms.Label lblBraki;
        private System.Windows.Forms.Label lblNorma;
        private System.Windows.Forms.Label lblOdczytane;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odczytane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przerwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Braki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nadgodziny;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transakcje;
        private System.Windows.Forms.DataGridView dgvZad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserZad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameZad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Czaspracy;
    }
}