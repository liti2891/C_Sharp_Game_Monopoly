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
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void GameStart_Click(object sender, EventArgs e)
        {            
            /*設定遊戲模式*/
            int Player = sPlayer.SelectedIndex + 2;
            int Map = sMap.SelectedIndex + 1;
            int Victory = sVictory.SelectedIndex + 1;
            bool FullScreen = checkBox1.Checked;
            if (Player < 2 || Map < 1 || Victory < 1)
            {
                MessageBox.Show("請選擇遊戲方式!");
                return;
            }

            /*載入遊戲*/
            Gaming GS = new Gaming(Player, Map, Victory, FullScreen);
            this.Visible = false;
            GS.Visible = true;
        }
    }
}