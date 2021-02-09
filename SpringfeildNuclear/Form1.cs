using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace SpringfeildNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void OutputLable_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer AlertPlayer = new SoundPlayer(Properties.Resources.alert);
            AlertPlayer.Play();

            OutputLabel.BackColor = Color.Red;
            OutputLabel.Text = "Meltdown Imminant";

            Reactor2StateLabel.BackColor = Color.Red;
            Reactor1StateLabel.BackColor = Color.Red;

            OutputLabel.BackColor = Color.White;
            OutputLabel.ForeColor = Color.Red;

            Refresh();
            Thread.Sleep(800);
            
            OutputLabel.BackColor = Color.Red;
            OutputLabel.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(800);

            OutputLabel.BackColor = Color.White;
            OutputLabel.ForeColor = Color.Red;

            Refresh();
            Thread.Sleep(800);

            OutputLabel.BackColor = Color.Red;
            OutputLabel.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(800);

            OutputLabel.BackColor = Color.White;
            OutputLabel.ForeColor = Color.Red;

            Refresh();
            Thread.Sleep(800);

            OutputLabel.BackColor = Color.Red;
            OutputLabel.ForeColor = Color.White;


        }

        private void Reactor2StateLable_Click(object sender, EventArgs e)
        {

        }

        private void Reactor1StateLable_Click(object sender, EventArgs e)
        {

        }
    }
}
