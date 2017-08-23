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
      Viktorina.allFolders = cbUseSubFolders.Checked;
      Viktorina.gameDuration = (int)nudGameDuration.Value;
      Viktorina.musicDuration = (int)nudMusicDuration.Value;
      Viktorina.randomStart = cbRandomStart.Checked;
      
      Viktorina.WriteParam();
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
        Viktorina.list.Clear();
        Viktorina.list.AddRange(music_list);
        Viktorina.lastFolder = fbd.SelectedPath;
      } 
    }

    private void btnSettingsCansel_Click(object sender, EventArgs e)
    {
      LaodSettings();
      Hide();
    }

    void LaodSettings()
    {
      cbUseSubFolders.Checked = Viktorina.allFolders;
      nudGameDuration.Value = Viktorina.gameDuration;
      nudMusicDuration.Value = Viktorina.musicDuration;
      cbRandomStart.Checked = Viktorina.randomStart;
    }

    private void btnClearMusucList_Click(object sender, EventArgs e)
    {
      lbMusicList.Items.Clear();
    }

    private void fSettings_Load(object sender, EventArgs e)
    {
      LaodSettings();
      lbMusicList.Items.Clear();
      lbMusicList.Items.AddRange(Viktorina.list.ToArray());
    }
  }
}
