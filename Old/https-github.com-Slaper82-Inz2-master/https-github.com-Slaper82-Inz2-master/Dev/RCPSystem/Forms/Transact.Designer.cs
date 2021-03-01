namespace RCPSystem.Forms
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
            this.gbTimeAttandance.SuspendLayout();
            this.gbTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rejestracja czasu pracy";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(17, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 49);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(243, 42);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 49);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Przerwa";
            // 
            // btnBreakOff
            // 
            this.btnBreakOff.Location = new System.Drawing.Point(243, 159);
            this.btnBreakOff.Name = "btnBreakOff";
            this.btnBreakOff.Size = new System.Drawing.Size(161, 49);
            this.btnBreakOff.TabIndex = 6;
            this.btnBreakOff.Text = "Koniec";
            this.btnBreakOff.UseVisualStyleBackColor = true;
            this.btnBreakOff.Click += new System.EventHandler(this.btnBreakOff_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(17, 159);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(161, 49);
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
            this.gbTimeAttandance.Location = new System.Drawing.Point(38, 124);
            this.gbTimeAttandance.Name = "gbTimeAttandance";
            this.gbTimeAttandance.Size = new System.Drawing.Size(481, 249);
            this.gbTimeAttandance.TabIndex = 7;
            this.gbTimeAttandance.TabStop = false;
            this.gbTimeAttandance.Text = "Czas pracy";
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.btnStartZad);
            this.gbTask.Controls.Add(this.dgvTask);
            this.gbTask.Location = new System.Drawing.Point(38, 397);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(828, 487);
            this.gbTask.TabIndex = 8;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Czas pracy zadania";
            // 
            // btnStartZad
            // 
            this.btnStartZad.Location = new System.Drawing.Point(30, 396);
            this.btnStartZad.Name = "btnStartZad";
            this.btnStartZad.Size = new System.Drawing.Size(194, 70);
            this.btnStartZad.TabIndex = 7;
            this.btnStartZad.Text = "Start";
            this.btnStartZad.UseVisualStyleBackColor = true;
            this.btnStartZad.Click += new System.EventHandler(this.btnStartZad_Click);
            // 
            // dgvTask
            // 
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.label2.Location = new System.Drawing.Point(1085, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Moje zadania";
            // 
            // dgvMyTasks
            // 
            this.dgvMyTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyTasks.Location = new System.Drawing.Point(1078, 101);
            this.dgvMyTasks.Name = "dgvMyTasks";
            this.dgvMyTasks.RowTemplate.Height = 24;
            this.dgvMyTasks.Size = new System.Drawing.Size(523, 783);
            this.dgvMyTasks.TabIndex = 9;
            this.dgvMyTasks.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvMyTasks_RowStateChanged);
            // 
            // btnTaskEnd
            // 
            this.btnTaskEnd.Location = new System.Drawing.Point(1078, 916);
            this.btnTaskEnd.Name = "btnTaskEnd";
            this.btnTaskEnd.Size = new System.Drawing.Size(194, 70);
            this.btnTaskEnd.TabIndex = 9;
            this.btnTaskEnd.Text = "Zakończ zadanie";
            this.btnTaskEnd.UseVisualStyleBackColor = true;
            this.btnTaskEnd.Click += new System.EventHandler(this.btnTaskEnd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(719, 350);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 41);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Odświerz listę";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Transact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1016);
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
    }
}