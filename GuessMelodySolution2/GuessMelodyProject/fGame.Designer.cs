namespace GuessMelodyProject
{
  partial class fGame
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
      this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
      this.btnGameNext = new System.Windows.Forms.Button();
      this.btnGamePause = new System.Windows.Forms.Button();
      this.btnGameContineue = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.lblPlayer1score = new System.Windows.Forms.Label();
      this.lblPlayer2score = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblGameMusicQty = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.lblTimer = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
      this.SuspendLayout();
      // 
      // WMP
      // 
      this.WMP.Enabled = true;
      this.WMP.Location = new System.Drawing.Point(220, 408);
      this.WMP.Name = "WMP";
      this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
      this.WMP.Size = new System.Drawing.Size(220, 47);
      this.WMP.TabIndex = 0;
      this.WMP.Visible = false;
      this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
      // 
      // btnGameNext
      // 
      this.btnGameNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.btnGameNext.Location = new System.Drawing.Point(220, 190);
      this.btnGameNext.Name = "btnGameNext";
      this.btnGameNext.Size = new System.Drawing.Size(200, 100);
      this.btnGameNext.TabIndex = 1;
      this.btnGameNext.Text = "Следующая";
      this.btnGameNext.UseVisualStyleBackColor = true;
      this.btnGameNext.Click += new System.EventHandler(this.btnGameNext_Click);
      // 
      // btnGamePause
      // 
      this.btnGamePause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.btnGamePause.Location = new System.Drawing.Point(220, 296);
      this.btnGamePause.Name = "btnGamePause";
      this.btnGamePause.Size = new System.Drawing.Size(200, 50);
      this.btnGamePause.TabIndex = 2;
      this.btnGamePause.Text = "Пауза";
      this.btnGamePause.UseVisualStyleBackColor = true;
      this.btnGamePause.Click += new System.EventHandler(this.btnGamePause_Click);
      // 
      // btnGameContineue
      // 
      this.btnGameContineue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.btnGameContineue.Location = new System.Drawing.Point(220, 352);
      this.btnGameContineue.Name = "btnGameContineue";
      this.btnGameContineue.Size = new System.Drawing.Size(200, 50);
      this.btnGameContineue.TabIndex = 3;
      this.btnGameContineue.Text = "Продолжить";
      this.btnGameContineue.UseVisualStyleBackColor = true;
      this.btnGameContineue.Click += new System.EventHandler(this.btnGameContineue_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(128, 37);
      this.label1.TabIndex = 4;
      this.label1.Text = "Игрок 1";
      // 
      // lblPlayer1score
      // 
      this.lblPlayer1score.AutoSize = true;
      this.lblPlayer1score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.lblPlayer1score.Location = new System.Drawing.Point(59, 46);
      this.lblPlayer1score.Name = "lblPlayer1score";
      this.lblPlayer1score.Size = new System.Drawing.Size(35, 37);
      this.lblPlayer1score.TabIndex = 5;
      this.lblPlayer1score.Text = "0";
      this.lblPlayer1score.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblPlayer1score_MouseClick);
      // 
      // lblPlayer2score
      // 
      this.lblPlayer2score.AutoSize = true;
      this.lblPlayer2score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.lblPlayer2score.Location = new System.Drawing.Point(531, 46);
      this.lblPlayer2score.Name = "lblPlayer2score";
      this.lblPlayer2score.Size = new System.Drawing.Size(35, 37);
      this.lblPlayer2score.TabIndex = 7;
      this.lblPlayer2score.Text = "0";
      this.lblPlayer2score.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblPlayer1score_MouseClick);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.label3.Location = new System.Drawing.Point(484, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(130, 37);
      this.label3.TabIndex = 6;
      this.label3.Text = "Игрок 2";
      // 
      // lblGameMusicQty
      // 
      this.lblGameMusicQty.AutoSize = true;
      this.lblGameMusicQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.lblGameMusicQty.Location = new System.Drawing.Point(302, 9);
      this.lblGameMusicQty.Name = "lblGameMusicQty";
      this.lblGameMusicQty.Size = new System.Drawing.Size(35, 37);
      this.lblGameMusicQty.TabIndex = 8;
      this.lblGameMusicQty.Text = "0";
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 134);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(600, 50);
      this.progressBar1.TabIndex = 9;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // lblTimer
      // 
      this.lblTimer.AutoSize = true;
      this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.lblTimer.Location = new System.Drawing.Point(302, 46);
      this.lblTimer.Name = "lblTimer";
      this.lblTimer.Size = new System.Drawing.Size(35, 37);
      this.lblTimer.TabIndex = 10;
      this.lblTimer.Text = "0";
      // 
      // fGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.lblTimer);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.lblGameMusicQty);
      this.Controls.Add(this.lblPlayer2score);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lblPlayer1score);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnGameContineue);
      this.Controls.Add(this.btnGamePause);
      this.Controls.Add(this.btnGameNext);
      this.Controls.Add(this.WMP);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "fGame";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Игра";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
      this.Load += new System.EventHandler(this.fGame_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private AxWMPLib.AxWindowsMediaPlayer WMP;
    private System.Windows.Forms.Button btnGameNext;
    private System.Windows.Forms.Button btnGamePause;
    private System.Windows.Forms.Button btnGameContineue;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblPlayer1score;
    private System.Windows.Forms.Label lblPlayer2score;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblGameMusicQty;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label lblTimer;
  }
}