namespace WinSteuerElemente
{
  partial class FrmTimerBgWorkerFsw
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
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.lblTime = new System.Windows.Forms.Label();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblStatusWorker = new System.Windows.Forms.ToolStripStatusLabel();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.btnStart = new System.Windows.Forms.Button();
      this.lbStatus = new System.Windows.Forms.ListBox();
      this.btnThreadTest = new System.Windows.Forms.Button();
      this.fswTemp = new System.IO.FileSystemWatcher();
      this.statusStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fswTemp)).BeginInit();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 500;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.Location = new System.Drawing.Point(28, 22);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(71, 32);
      this.lblTime.TabIndex = 0;
      this.lblTime.Text = "...";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusTime,
            this.lblStatusWorker});
      this.statusStrip1.Location = new System.Drawing.Point(0, 522);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(837, 30);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // lblStatusTime
      // 
      this.lblStatusTime.Name = "lblStatusTime";
      this.lblStatusTime.Size = new System.Drawing.Size(94, 25);
      this.lblStatusTime.Text = "HH:mm:ss";
      // 
      // lblStatusWorker
      // 
      this.lblStatusWorker.Name = "lblStatusWorker";
      this.lblStatusWorker.Size = new System.Drawing.Size(73, 25);
      this.lblStatusWorker.Text = "Bereit...";
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.WorkerReportsProgress = true;
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(34, 72);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(226, 37);
      this.btnStart.TabIndex = 2;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lbStatus
      // 
      this.lbStatus.FormattingEnabled = true;
      this.lbStatus.ItemHeight = 21;
      this.lbStatus.Location = new System.Drawing.Point(34, 138);
      this.lbStatus.Name = "lbStatus";
      this.lbStatus.Size = new System.Drawing.Size(226, 340);
      this.lbStatus.TabIndex = 3;
      // 
      // btnThreadTest
      // 
      this.btnThreadTest.Location = new System.Drawing.Point(409, 72);
      this.btnThreadTest.Name = "btnThreadTest";
      this.btnThreadTest.Size = new System.Drawing.Size(226, 37);
      this.btnThreadTest.TabIndex = 4;
      this.btnThreadTest.Text = "Test";
      this.btnThreadTest.UseVisualStyleBackColor = true;
      this.btnThreadTest.Click += new System.EventHandler(this.btnThreadTest_Click);
      // 
      // fswTemp
      // 
      this.fswTemp.EnableRaisingEvents = true;
      this.fswTemp.Filter = "*.txt";
      this.fswTemp.NotifyFilter = ((System.IO.NotifyFilters)((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.LastWrite) 
            | System.IO.NotifyFilters.CreationTime)));
      this.fswTemp.Path = "F:\\Temp";
      this.fswTemp.SynchronizingObject = this;
      this.fswTemp.Changed += new System.IO.FileSystemEventHandler(this.fswTemp_Changed);
      this.fswTemp.Created += new System.IO.FileSystemEventHandler(this.fswTemp_Created);
      this.fswTemp.Deleted += new System.IO.FileSystemEventHandler(this.fswTemp_Deleted);
      // 
      // FrmTimerBgWorkerFsw
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(837, 552);
      this.Controls.Add(this.btnThreadTest);
      this.Controls.Add(this.lbStatus);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.lblTime);
      this.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.Name = "FrmTimerBgWorkerFsw";
      this.Text = "FrmTimerBgWorkerFsw";
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fswTemp)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblStatusTime;
    private System.Windows.Forms.ToolStripStatusLabel lblStatusWorker;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.ListBox lbStatus;
    private System.Windows.Forms.Button btnThreadTest;
    private System.IO.FileSystemWatcher fswTemp;
  }
}