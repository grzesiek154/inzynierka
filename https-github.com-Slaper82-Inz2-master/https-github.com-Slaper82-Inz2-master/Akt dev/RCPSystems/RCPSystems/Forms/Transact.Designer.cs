namespace RCPSystems.Forms
{
    partial class Transact
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBreakOff = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.gbTimeAttandance = new System.Windows.Forms.GroupBox();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.btnStartZad = new System.Windows.Forms.Button();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMyTasks = new System.Windows.Forms.DataGridView();
            this.btnTaskEnd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.IdMyTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTimeAttandance.SuspendLayout();
            this.gbTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rejestracja czasu pracy";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(191, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(143, 38);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Przerwa";
            // 
            // btnBreakOff
            // 
            this.btnBreakOff.Location = new System.Drawing.Point(191, 108);
            this.btnBreakOff.Name = "btnBreakOff";
            this.btnBreakOff.Size = new System.Drawing.Size(143, 36);
            this.btnBreakOff.TabIndex = 6;
            this.btnBreakOff.Text = "Koniec";
            this.btnBreakOff.UseVisualStyleBackColor = true;
            this.btnBreakOff.Click += new System.EventHandler(this.btnBreakOff_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(7, 108);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(144, 36);
            this.btnBreak.TabIndex = 5;
            this.btnBreak.Text = "Początek";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // gbTimeAttandance
            // 
            this.gbTimeAttandance.Controls.Add(this.btnStart);
            this.gbTimeAttandance.Controls.Add(this.btnBreakOff);
            this.gbTimeAttandance.Controls.Add(this.btnStop);
            this.gbTimeAttandance.Controls.Add(this.btnBreak);
            this.gbTimeAttandance.Controls.Add(this.label3);
            this.gbTimeAttandance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTimeAttandance.Location = new System.Drawing.Point(31, 59);
            this.gbTimeAttandance.Name = "gbTimeAttandance";
            this.gbTimeAttandance.Size = new System.Drawing.Size(386, 173);
            this.gbTimeAttandance.TabIndex = 7;
            this.gbTimeAttandance.TabStop = false;
            this.gbTimeAttandance.Text = "Czas pracy";
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.btnStartZad);
            this.gbTask.Controls.Add(this.dgvTask);
            this.gbTask.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTask.Location = new System.Drawing.Point(38, 261);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(828, 456);
            this.gbTask.TabIndex = 8;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Czas pracy zadania";
            // 
            // btnStartZad
            // 
            this.btnStartZad.Location = new System.Drawing.Point(30, 396);
            this.btnStartZad.Name = "btnStartZad";
            this.btnStartZad.Size = new System.Drawing.Size(167, 40);
            this.btnStartZad.TabIndex = 7;
            this.btnStartZad.Text = "Start";
            this.btnStartZad.UseVisualStyleBackColor = true;
            this.btnStartZad.Click += new System.EventHandler(this.btnStartZad_Click);
            // 
            // dgvTask
            // 
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTask,
            this.Nazwa,
            this.IdOrder,
            this.Quantity,
            this.Done});
            this.dgvTask.Location = new System.Drawing.Point(30, 50);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowTemplate.Height = 24;
            this.dgvTask.Size = new System.Drawing.Size(770, 326);
            this.dgvTask.TabIndex = 8;
            this.dgvTask.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvTask_RowStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(894, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Moje zadania";
            // 
            // dgvMyTasks
            // 
            this.dgvMyTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMyTask,
            this.Start,
            this.Stop,
            this.AddInfo});
            this.dgvMyTasks.Location = new System.Drawing.Point(898, 59);
            this.dgvMyTasks.Name = "dgvMyTasks";
            this.dgvMyTasks.RowTemplate.Height = 24;
            this.dgvMyTasks.Size = new System.Drawing.Size(523, 480);
            this.dgvMyTasks.TabIndex = 9;
            this.dgvMyTasks.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvMyTasks_RowStateChanged);
            // 
            // btnTaskEnd
            // 
            this.btnTaskEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTaskEnd.Location = new System.Drawing.Point(898, 629);
            this.btnTaskEnd.Name = "btnTaskEnd";
            this.btnTaskEnd.Size = new System.Drawing.Size(185, 47);
            this.btnTaskEnd.TabIndex = 9;
            this.btnTaskEnd.Text = "Zakończ zadanie";
            this.btnTaskEnd.UseVisualStyleBackColor = true;
            this.btnTaskEnd.Click += new System.EventHandler(this.btnTaskEnd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(719, 214);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 41);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Odświerz listę";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(898, 557);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(185, 48);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Zatrzymaj pracę";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1236, 557);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(185, 48);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Rozpocznij pracę";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // IdMyTask
            // 
            this.IdMyTask.DataPropertyName = "IdTask";
            this.IdMyTask.HeaderText = "Nr zadania";
            this.IdMyTask.Name = "IdMyTask";
            // 
            // Start
            // 
            this.Start.DataPropertyName = "Start";
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            // 
            // Stop
            // 
            this.Stop.DataPropertyName = "Stop";
            this.Stop.HeaderText = "Stop";
            this.Stop.Name = "Stop";
            // 
            // AddInfo
            // 
            this.AddInfo.DataPropertyName = "AddInfo";
            this.AddInfo.HeaderText = "Dodatkowa informacja";
            this.AddInfo.Name = "AddInfo";
            // 
            // IdTask
            // 
            this.IdTask.DataPropertyName = "NrZadania";
            this.IdTask.HeaderText = "Nr zadania";
            this.IdTask.Name = "IdTask";
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            // 
            // IdOrder
            // 
            this.IdOrder.DataPropertyName = "NrZamowienia";
            this.IdOrder.HeaderText = "Nr Zamówienia";
            this.IdOrder.Name = "IdOrder";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Ilosc";
            this.Quantity.HeaderText = "Ilość";
            this.Quantity.Name = "Quantity";
            // 
            // Done
            // 
            this.Done.DataPropertyName = "Status";
            this.Done.HeaderText = "Status";
            this.Done.Name = "Done";
            // 
            // Transact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 765);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTaskEnd);
            this.Controls.Add(this.dgvMyTasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.gbTimeAttandance);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Transact";
            this.Text = "Transact";
            this.gbTimeAttandance.ResumeLayout(false);
            this.gbTimeAttandance.PerformLayout();
            this.gbTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBreakOff;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.GroupBox gbTimeAttandance;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.Button btnStartZad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMyTasks;
        private System.Windows.Forms.Button btnTaskEnd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMyTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stop;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Done;
    }
}