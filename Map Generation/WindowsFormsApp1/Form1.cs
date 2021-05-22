using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float X;//當前窗體的寬度
        private float Y;//當前窗體的高度
        private void Form1_Load(object sender, EventArgs e)
        {
            X = this.Width;//獲取窗體的寬度
            Y = this.Height;//獲取窗體的高度
            placeselect = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 };
            SetTag(this);//調用方法    
            draw = pictureBox1.CreateGraphics();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetControls(this.Width / X, this.Height / Y, this);
        }

        private void SetTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    SetTag(con);
            }
        }
        private void SetControls(float newx, float newy, Control cons)
        {
            //遍歷窗體中的控制項，重新設置控制項的值
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//獲取控制項的Tag屬性值，並分割後存儲字元串數組
                float a = System.Convert.ToSingle(mytag[0]) * newx;//根據窗體縮放比例確定控制項的值，寬度
                con.Width = (int)a;//寬度
                a = System.Convert.ToSingle(mytag[1]) * newy;//高度
                con.Height = (int)(a);
                a = System.Convert.ToSingle(mytag[2]) * newx;//左邊距離
                con.Left = (int)(a);
                a = System.Convert.ToSingle(mytag[3]) * newy;//上邊緣距離
                con.Top = (int)(a);
                Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字體大小
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    SetControls(newx, newy, con);
                }
            }
        }
       
        List<string> lists = new List<string>();
        RadioButton[] placeselect;
        Graphics draw;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int i = listBox1.Items.Count;
            int place=-1;
            for(int j = 0; j < 6; j++)
            {
                if (placeselect[j].Checked)
                    place = j;
            }
            Color[] PColor=new Color[6];
            PColor[0] = Color.Red;
            PColor[1] = Color.Blue;
            PColor[2] = Color.Yellow;
            PColor[3] = Color.Orange;
            PColor[4] = Color.Green;
            PColor[5] = Color.YellowGreen;
            try
            {
                draw.DrawEllipse(new Pen(PColor[place], 5), e.X, e.Y, 3, 3);
                draw.DrawString(i.ToString(), new Font("新細明體", 10), Brushes.Yellow, e.X + 3, e.Y + 3);
                listBox1.Items.Add(i + ":" + place + ".( " + e.X + " , " + e.Y + " )");
                lists.Add(place + ":" + e.X + ":" + e.Y);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(textBox1.Text);
            }
            catch {   }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = listBox1.Items.Count - 1;
                listBox1.Items.RemoveAt(idx);
                lists.RemoveAt(idx);
            }
            catch {   }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // 將字串寫入TXT檔
            StreamWriter str = new StreamWriter(@"map.TXT");
            str.WriteLine(lists.Count);
            for (int i = 0; i < lists.Count; i++)
            {
                str.WriteLine(lists[i]);
            }
            str.Close();
        }
    }
}