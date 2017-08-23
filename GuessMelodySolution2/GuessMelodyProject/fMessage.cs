using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessMelodyProject
{
  public partial class fMessage : Form
  {
    int timeAnswer = 5;

    public fMessage()
    {
      InitializeComponent();
    }

    private void fMessage_Load(object sender, EventArgs e)
    {
      timeAnswer = 5;
      timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      timeAnswer--;
      lblTimer.Text = timeAnswer.ToString();
      if (timeAnswer == 0)
      {
        timer1.Stop();
        //SoundPlayer sp = new SoundPlayer("Resources\\7.wav");
        //sp.Play();
      }
    }

    private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
    {
      timer1.Stop();
    }
  }
}
