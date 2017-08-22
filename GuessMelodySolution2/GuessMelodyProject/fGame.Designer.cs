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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
      this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
      this.btnGameNext = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
      this.SuspendLayout();
      // 
      // WMP
      // 
      this.WMP.Enabled = true;
      this.WMP.Location = new System.Drawing.Point(12, 382);
      this.WMP.Name = "WMP";
      this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
      this.WMP.Size = new System.Drawing.Size(220, 47);
      this.WMP.TabIndex = 0;
      this.WMP.Visible = false;
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
      // fGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.btnGameNext);
      this.Controls.Add(this.WMP);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "fGame";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Игра";
      ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private AxWMPLib.AxWindowsMediaPlayer WMP;
    private System.Windows.Forms.Button btnGameNext;
  }
}