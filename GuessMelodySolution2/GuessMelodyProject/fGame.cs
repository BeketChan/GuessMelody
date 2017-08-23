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

    public fGame()
    {
      InitializeComponent();
    }

    void MakeMusic()
    {
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
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      progressBar1.Value++;
      if (progressBar1.Value == progressBar1.Maximum)
      {
        timer1.Stop();
        WMP.Ctlcontrols.stop();
      }
    }

    private void btnGamePause_Click(object sender, EventArgs e)
    {
      timer1.Stop();
      WMP.Ctlcontrols.pause();
    }

    private void btnGameContineue_Click(object sender, EventArgs e)
    {
      timer1.Start();
      WMP.Ctlcontrols.play();
    }
  }
}
