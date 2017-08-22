namespace GuessMelodyProject
{
  partial class fMain
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
      this.btnStartGame = new System.Windows.Forms.Button();
      this.btnSettings = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnStartGame
      // 
      this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.btnStartGame.Location = new System.Drawing.Point(160, 60);
      this.btnStartGame.Name = "btnStartGame";
      this.btnStartGame.Size = new System.Drawing.Size(300, 50);
      this.btnStartGame.TabIndex = 0;
      this.btnStartGame.Text = "НАЧАЛО ИГРЫ";
      this.btnStartGame.UseVisualStyleBackColor = true;
      this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
      // 
      // btnSettings
      // 
      this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.btnSettings.Location = new System.Drawing.Point(160, 140);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Size = new System.Drawing.Size(300, 50);
      this.btnSettings.TabIndex = 1;
      this.btnSettings.Text = "НАСТРОЙКА";
      this.btnSettings.UseVisualStyleBackColor = true;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // btnExit
      // 
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
      this.btnExit.Location = new System.Drawing.Point(160, 220);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(300, 50);
      this.btnExit.TabIndex = 2;
      this.btnExit.Text = "ВЫХОД";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.button1_Click);
      // 
      // fMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnSettings);
      this.Controls.Add(this.btnStartGame);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "fMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Угадай мелодию";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnStartGame;
    private System.Windows.Forms.Button btnSettings;
    private System.Windows.Forms.Button btnExit;
  }
}

