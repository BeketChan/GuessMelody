using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelodyProject
{
  public partial class fGame : Form
  {
    Random rnd = new Random();
    int musicDuration = Viktorina.musicDuration;

    public fGame()
    {
      InitializeComponent();
    }

    void MakeMusic()
    {
      if (Viktorina.list.Count == 0) EndGame();
      musicDuration = Viktorina.musicDuration;
      int n = rnd.Next(0, Viktorina.list.Count - 1);
      WMP.URL = Viktorina.list[n];
      WMP.Ctlcontrols.play();
      Viktorina.list.RemoveAt(n);
      lblGameMusicQty.Text = Viktorina.list.Count.ToString();
    }

    private void btnGameNext_Click(object sender, EventArgs e)
    {
      MakeMusic();
      timer1.Start();
    }

    private void fGame_FormClosed(object sender, FormClosedEventArgs e)
    {
      WMP.Ctlcontrols.stop();
      timer1.Stop();
    }

    private void fGame_Load(object sender, EventArgs e)
    {
      lblGameMusicQty.Text = Viktorina.list.Count.ToString();
      progressBar1.Maximum = Viktorina.gameDuration;
      progressBar1.Value = 0;
      musicDuration = Viktorina.musicDuration;
      lblTimer.Text = musicDuration.ToString();
    }

    void EndGame()
    {
      timer1.Stop();
      WMP.Ctlcontrols.stop();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      progressBar1.Value++;
      musicDuration--;
      lblTimer.Text = musicDuration.ToString();
      if (progressBar1.Value == progressBar1.Maximum)
      {
        EndGame();
        return;
      }
      if (musicDuration == 0) MakeMusic();
    }

    private void btnGamePause_Click(object sender, EventArgs e)
    {
      GamePause();
    }

    private void btnGameContineue_Click(object sender, EventArgs e)
    {
      GamePlay();
    }

    void GamePause()
    {
      timer1.Stop();
      WMP.Ctlcontrols.pause();
    }

    void GamePlay()
    {
      timer1.Start();
      WMP.Ctlcontrols.play();
    }

    private void fGame_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.A)
      {
        GamePause();
        fMessage fm = new fMessage();
        fm.lbMessagePlayerNo.Text = "Игрок 1";
        if (fm.ShowDialog() == DialogResult.Yes)
        {
          lblPlayer1score.Text = Convert.ToString(Convert.ToInt32(lblPlayer1score.Text) + 1);
          MakeMusic();
        }
        GamePlay();
      }
      if (e.KeyData == Keys.P)
      {
        GamePause();
        fMessage fm = new fMessage();
        fm.lbMessagePlayerNo.Text = "Игрок 2";
        if (fm.ShowDialog() == DialogResult.Yes)
        {
          lblPlayer2score.Text = Convert.ToString(Convert.ToInt32(lblPlayer2score.Text) + 1);
          MakeMusic();
        }
        GamePlay();
      }
    }

    private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
    {
      if (Viktorina.randomStart && (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen))
        WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration - Viktorina.musicDuration);
    }
  }
}
