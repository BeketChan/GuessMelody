namespace GuessMelodyProject
{
  partial class fSettings
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
      this.lbMusicList = new System.Windows.Forms.ListBox();
      this.btnSelectFolder = new System.Windows.Forms.Button();
      this.btnClearMusucList = new System.Windows.Forms.Button();
      this.cbUseSubFolders = new System.Windows.Forms.CheckBox();
      this.btnSettingsCansel = new System.Windows.Forms.Button();
      this.btnSettibgsOK = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.nudGameDuration = new System.Windows.Forms.NumericUpDown();
      this.nudMusicDuration = new System.Windows.Forms.NumericUpDown();
      this.cbRandomStart = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cbPlayer1key = new System.Windows.Forms.ComboBox();
      this.cbPlayer2key = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.nudGameDuration)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMusicDuration)).BeginInit();
      this.SuspendLayout();
      // 
      // lbMusicList
      // 
      this.lbMusicList.FormattingEnabled = true;
      this.lbMusicList.Location = new System.Drawing.Point(12, 12);
      this.lbMusicList.Name = "lbMusicList";
      this.lbMusicList.Size = new System.Drawing.Size(600, 316);
      this.lbMusicList.TabIndex = 0;
      // 
      // btnSelectFolder
      // 
      this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnSelectFolder.Location = new System.Drawing.Point(13, 335);
      this.btnSelectFolder.Name = "btnSelectFolder";
      this.btnSelectFolder.Size = new System.Drawing.Size(160, 30);
      this.btnSelectFolder.TabIndex = 1;
      this.btnSelectFolder.Text = "Выбрать папку";
      this.btnSelectFolder.UseVisualStyleBackColor = true;
      this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
      // 
      // btnClearMusucList
      // 
      this.btnClearMusucList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnClearMusucList.Location = new System.Drawing.Point(179, 335);
      this.btnClearMusucList.Name = "btnClearMusucList";
      this.btnClearMusucList.Size = new System.Drawing.Size(160, 30);
      this.btnClearMusucList.TabIndex = 2;
      this.btnClearMusucList.Text = "Очистить";
      this.btnClearMusucList.UseVisualStyleBackColor = true;
      this.btnClearMusucList.Click += new System.EventHandler(this.btnClearMusucList_Click);
      // 
      // cbUseSubFolders
      // 
      this.cbUseSubFolders.AutoSize = true;
      this.cbUseSubFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.cbUseSubFolders.Location = new System.Drawing.Point(345, 338);
      this.cbUseSubFolders.Name = "cbUseSubFolders";
      this.cbUseSubFolders.Size = new System.Drawing.Size(164, 24);
      this.cbUseSubFolders.TabIndex = 3;
      this.cbUseSubFolders.Text = "Вложенные папки";
      this.cbUseSubFolders.UseVisualStyleBackColor = true;
      // 
      // btnSettingsCansel
      // 
      this.btnSettingsCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnSettingsCansel.Location = new System.Drawing.Point(532, 399);
      this.btnSettingsCansel.Name = "btnSettingsCansel";
      this.btnSettingsCansel.Size = new System.Drawing.Size(80, 30);
      this.btnSettingsCansel.TabIndex = 4;
      this.btnSettingsCansel.Text = "Отмена";
      this.btnSettingsCansel.UseVisualStyleBackColor = true;
      this.btnSettingsCansel.Click += new System.EventHandler(this.btnSettingsCansel_Click);
      // 
      // btnSettibgsOK
      // 
      this.btnSettibgsOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnSettibgsOK.Location = new System.Drawing.Point(532, 363);
      this.btnSettibgsOK.Name = "btnSettibgsOK";
      this.btnSettibgsOK.Size = new System.Drawing.Size(80, 30);
      this.btnSettibgsOK.TabIndex = 5;
      this.btnSettibgsOK.Text = "ОК";
      this.btnSettibgsOK.UseVisualStyleBackColor = true;
      this.btnSettibgsOK.Click += new System.EventHandler(this.btnSettibgsOK_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label1.Location = new System.Drawing.Point(13, 372);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(210, 20);
      this.label1.TabIndex = 6;
      this.label1.Text = "Продолжительность игры";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label2.Location = new System.Drawing.Point(13, 399);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(129, 20);
      this.label2.TabIndex = 7;
      this.label2.Text = "Время на ответ";
      // 
      // nudGameDuration
      // 
      this.nudGameDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.nudGameDuration.Location = new System.Drawing.Point(229, 370);
      this.nudGameDuration.Name = "nudGameDuration";
      this.nudGameDuration.Size = new System.Drawing.Size(51, 26);
      this.nudGameDuration.TabIndex = 8;
      this.nudGameDuration.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
      // 
      // nudMusicDuration
      // 
      this.nudMusicDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.nudMusicDuration.Location = new System.Drawing.Point(229, 397);
      this.nudMusicDuration.Name = "nudMusicDuration";
      this.nudMusicDuration.Size = new System.Drawing.Size(51, 26);
      this.nudMusicDuration.TabIndex = 9;
      this.nudMusicDuration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // cbRandomStart
      // 
      this.cbRandomStart.AutoSize = true;
      this.cbRandomStart.Checked = true;
      this.cbRandomStart.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbRandomStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.cbRandomStart.Location = new System.Drawing.Point(17, 422);
      this.cbRandomStart.Name = "cbRandomStart";
      this.cbRandomStart.Size = new System.Drawing.Size(188, 24);
      this.cbRandomStart.TabIndex = 10;
      this.cbRandomStart.Text = "Со случайного места";
      this.cbRandomStart.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label3.Location = new System.Drawing.Point(286, 399);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(62, 20);
      this.label3.TabIndex = 12;
      this.label3.Text = "Игрок2";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label4.Location = new System.Drawing.Point(286, 372);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(62, 20);
      this.label4.TabIndex = 11;
      this.label4.Text = "Игрок1";
      // 
      // cbPlayer1key
      // 
      this.cbPlayer1key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.cbPlayer1key.FormattingEnabled = true;
      this.cbPlayer1key.Location = new System.Drawing.Point(355, 372);
      this.cbPlayer1key.Name = "cbPlayer1key";
      this.cbPlayer1key.Size = new System.Drawing.Size(40, 24);
      this.cbPlayer1key.TabIndex = 13;
      this.cbPlayer1key.Text = "A";
      // 
      // cbPlayer2key
      // 
      this.cbPlayer2key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.cbPlayer2key.FormattingEnabled = true;
      this.cbPlayer2key.Location = new System.Drawing.Point(354, 397);
      this.cbPlayer2key.Name = "cbPlayer2key";
      this.cbPlayer2key.Size = new System.Drawing.Size(40, 24);
      this.cbPlayer2key.TabIndex = 14;
      this.cbPlayer2key.Text = "P";
      // 
      // fSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.cbPlayer2key);
      this.Controls.Add(this.cbPlayer1key);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cbRandomStart);
      this.Controls.Add(this.nudMusicDuration);
      this.Controls.Add(this.nudGameDuration);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSettibgsOK);
      this.Controls.Add(this.btnSettingsCansel);
      this.Controls.Add(this.cbUseSubFolders);
      this.Controls.Add(this.btnClearMusucList);
      this.Controls.Add(this.btnSelectFolder);
      this.Controls.Add(this.lbMusicList);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "fSettings";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Настройки";
      this.Load += new System.EventHandler(this.fSettings_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nudGameDuration)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMusicDuration)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbMusicList;
    private System.Windows.Forms.Button btnSelectFolder;
    private System.Windows.Forms.Button btnClearMusucList;
    private System.Windows.Forms.CheckBox cbUseSubFolders;
    private System.Windows.Forms.Button btnSettingsCansel;
    private System.Windows.Forms.Button btnSettibgsOK;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown nudGameDuration;
    private System.Windows.Forms.NumericUpDown nudMusicDuration;
    private System.Windows.Forms.CheckBox cbRandomStart;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cbPlayer1key;
    private System.Windows.Forms.ComboBox cbPlayer2key;
  }
}