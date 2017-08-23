namespace GuessMelodyProject
{
  partial class fMessage
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
      this.lbMessagePlayerNo = new System.Windows.Forms.Label();
      this.btnMessageYes = new System.Windows.Forms.Button();
      this.btnMessageNo = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.lblTimer = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lbMessagePlayerNo
      // 
      this.lbMessagePlayerNo.AutoSize = true;
      this.lbMessagePlayerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.lbMessagePlayerNo.Location = new System.Drawing.Point(12, 9);
      this.lbMessagePlayerNo.Name = "lbMessagePlayerNo";
      this.lbMessagePlayerNo.Size = new System.Drawing.Size(100, 37);
      this.lbMessagePlayerNo.TabIndex = 0;
      this.lbMessagePlayerNo.Text = "label1";
      // 
      // btnMessageYes
      // 
      this.btnMessageYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
      this.btnMessageYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.btnMessageYes.Location = new System.Drawing.Point(148, 369);
      this.btnMessageYes.Name = "btnMessageYes";
      this.btnMessageYes.Size = new System.Drawing.Size(160, 60);
      this.btnMessageYes.TabIndex = 2;
      this.btnMessageYes.Text = "ДА";
      this.btnMessageYes.UseVisualStyleBackColor = true;
      // 
      // btnMessageNo
      // 
      this.btnMessageNo.DialogResult = System.Windows.Forms.DialogResult.No;
      this.btnMessageNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.btnMessageNo.Location = new System.Drawing.Point(314, 369);
      this.btnMessageNo.Name = "btnMessageNo";
      this.btnMessageNo.Size = new System.Drawing.Size(160, 60);
      this.btnMessageNo.TabIndex = 3;
      this.btnMessageNo.Text = "НЕТ";
      this.btnMessageNo.UseVisualStyleBackColor = true;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // lblTimer
      // 
      this.lblTimer.AutoSize = true;
      this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
      this.lblTimer.Location = new System.Drawing.Point(280, 173);
      this.lblTimer.Name = "lblTimer";
      this.lblTimer.Size = new System.Drawing.Size(51, 55);
      this.lblTimer.TabIndex = 4;
      this.lblTimer.Text = "0";
      // 
      // fMessage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.lblTimer);
      this.Controls.Add(this.btnMessageNo);
      this.Controls.Add(this.btnMessageYes);
      this.Controls.Add(this.lbMessagePlayerNo);
      this.Name = "fMessage";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Сообщение";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMessage_FormClosed);
      this.Load += new System.EventHandler(this.fMessage_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnMessageYes;
    private System.Windows.Forms.Button btnMessageNo;
    public System.Windows.Forms.Label lbMessagePlayerNo;
    private System.Windows.Forms.Timer timer1;
    public System.Windows.Forms.Label lblTimer;
  }
}