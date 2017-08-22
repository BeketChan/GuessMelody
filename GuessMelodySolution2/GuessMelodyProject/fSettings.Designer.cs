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
      this.btnSettibgsOK.Location = new System.Drawing.Point(446, 399);
      this.btnSettibgsOK.Name = "btnSettibgsOK";
      this.btnSettibgsOK.Size = new System.Drawing.Size(80, 30);
      this.btnSettibgsOK.TabIndex = 5;
      this.btnSettibgsOK.Text = "ОК";
      this.btnSettibgsOK.UseVisualStyleBackColor = true;
      this.btnSettibgsOK.Click += new System.EventHandler(this.btnSettibgsOK_Click);
      // 
      // fSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.btnSettibgsOK);
      this.Controls.Add(this.btnSettingsCansel);
      this.Controls.Add(this.cbUseSubFolders);
      this.Controls.Add(this.btnClearMusucList);
      this.Controls.Add(this.btnSelectFolder);
      this.Controls.Add(this.lbMusicList);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "fSettings";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Настройки";
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
  }
}