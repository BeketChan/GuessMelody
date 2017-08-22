using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelodyProject
{
  public partial class fSettings : Form
  {
    public fSettings()
    {
      InitializeComponent();
    }

    private void btnSettibgsOK_Click(object sender, EventArgs e)
    {
      Hide();
    }

    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbUseSubFolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
        lbMusicList.Items.Clear();
        lbMusicList.Items.AddRange(music_list);
      } 
    }

    private void btnSettingsCansel_Click(object sender, EventArgs e)
    {
      Hide();
    }

    private void btnClearMusucList_Click(object sender, EventArgs e)
    {
      lbMusicList.Items.Clear();
    }
  }
}
