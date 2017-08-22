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
  public partial class fMain : Form
  {
    fSettings sf = new fSettings();
    fGame fg = new fGame();

    public fMain()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Close();

    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      sf.ShowDialog();
    }

    private void btnStartGame_Click(object sender, EventArgs e)
    {
      fg.ShowDialog();
    }
  }
}
