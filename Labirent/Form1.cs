using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent
{
    public partial class Form1 : Form
    {

        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\samet\Desktop\TWİTCH malzemeleri\wav\ritim1.wav");
        System.Media.SoundPlayer endSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\samet\Desktop\TWİTCH malzemeleri\wav\crash.ses.efekt.wav");
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void lbl_finish_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            
            endSoundPlayer.Play();
            MessageBox.Show("Tebrikler, labirentten kurtulmayı başardınız !!    "+"Puanınız:"+sayac);
            Close();
        }
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            sayac = 0;
            lbl_Puan.Text = sayac.ToString();
            timer1.Start();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);// panel baş köşesinden onar birim uzak başlatır
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
           // MoveToStart();
            MessageBox.Show("Duvara tostladın :(    "+"Puanın:    "+sayac);
            MoveToStart();
        }

        private void lbl_start_MouseEnter(object sender, EventArgs e)
        {

        }

        int sayac=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            lbl_Puan.Text = sayac.ToString();
            
            
        }
    }
}
