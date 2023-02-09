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


namespace FirstGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources._321_sound);
            SoundPlayer playerstart = new SoundPlayer(Properties.Resources.start_sound);

            ClickToStartLabel.Visible = false;

            startButton1.Visible = false;

            Refresh();
            Thread.Sleep (1000);

            countdownLabel3.Visible = true;
            player.Play();


            Refresh();
            Thread.Sleep(1000);

            countdownLabel2.Visible = true;
            player.Play();

            Refresh();
            Thread.Sleep (1000);

            countdownLabel1.Visible = true;
            player.Play();

            Refresh();
            Thread.Sleep(1000);

            countdownLabel3.Visible = false;
            countdownLabel2.Visible = false;
            countdownLabel1.Visible = false;

            goLabel.Visible = true;

            playerstart.Play();

            this.BackColor = Color.DarkGreen;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
