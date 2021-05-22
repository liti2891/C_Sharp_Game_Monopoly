using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_1._0
{
    public partial class Anime : Form
    {
        public Anime()
        {
            InitializeComponent();            
        }
        public async void Play(String Path,String Sound,int time)
        {
            /*播放動畫及音效*/
            this.Visible = true;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
            sound.SoundLocation = (System.Windows.Forms.Application.StartupPath + @"\Data\" + Sound);
            sound.Play();
            tmp.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\Data\" + Path);
            await Task.Delay(time);
            this.Visible = false;
            tmp.Image = null;
        }
        public void AResize(float X,float Y)
        {
            this.Size = new Size((int)(this.Width * X), (int)(this.Height * Y));
            tmp.Width = this.Width;
            tmp.Height = this.Height;
        }        
    }
}
