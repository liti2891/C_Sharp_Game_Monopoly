using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_1._0
{
    public partial class Gaming : Form
    {
        /*----------------------------------------視窗--------------------------------------------------------*/
        private float ScreenX = 1024, ScreenY = 768;//預設視窗大小
        private void SetTag(Control cons)
        {
            /*儲存所有控制項大小、位置*/
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    SetTag(con);
            }
        }
        private void SetControls(float newx, float newy, Control cons)
        {
            /*重新設定所有控制項大小、位置*/
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//獲取控制項的Tag屬性值，並分割後存儲字元串數組
                float Scale = System.Convert.ToSingle(mytag[0]) * newx;//根據窗體縮放比例確定控制項的值，寬度
                con.Width = (int)Scale;//寬度
                Scale = System.Convert.ToSingle(mytag[1]) * newy;//高度
                con.Height = (int)(Scale);
                Scale = System.Convert.ToSingle(mytag[2]) * newx;//左邊距離
                con.Left = (int)(Scale);
                Scale = System.Convert.ToSingle(mytag[3]) * newy;//上邊緣距離
                con.Top = (int)(Scale);
                Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字體大小
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    SetControls(newx, newy, con);
                }
            }
        }
        private void Gaming_Resize(object sender, EventArgs e)
        {
            /*重新設定視窗*/
            float ScaleX = this.Width / ScreenX;
            float ScaleY = this.Height / ScreenY;
            Anime.AResize(ScaleX, ScaleY);
            HouseX = (int)(HouseX * ScaleX);
            HouseY = (int)(HouseY * ScaleY);
            SetControls(ScaleX, ScaleY, this);
            ScreenX = this.Width;
            ScreenY = this.Height;

            /*重新設定地圖座標*/
            for (int i = 0; i < Mamount; i++)
            {
                MLocation[i].X = (int)(MLocation[i].X * ScaleX);
                MLocation[i].Y = (int)(MLocation[i].Y * ScaleY);
            }
        }
        private void Gaming_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*關閉遊戲*/
            Application.Exit();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            /*關閉遊戲*/
            Application.Exit();
        }        

        /*----------------------------------------遊戲--------------------------------------------------------*/
        public Gaming(int Player, int Map, int Victory, bool FScreen)
        {
            InitializeComponent();            
            nPlayer = Player;
            nMap = Map;
            FullScreen = FScreen;
            switch (Victory)
            {
                case 1:
                    Won_P = Player;
                    Won_T = -1;
                    break;
                case 2:
                    Won_P = Player;
                    Won_T = 10;
                    TIMER.Text = "剩餘10分鐘";
                    GameTimer.Start();
                    break;
                default:
                    break;
            }
            ReadGame();            
        }
        private void Gaming_Load(object sender, EventArgs e)
        {
            SetTag(this);//儲存控制項狀態

            /*全螢幕*/          
            if (FullScreen)
            {
                Exit.Visible = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }            
        }
        
        bool FullScreen;//全螢幕        
        int nPlayer, nMap, Won_P, Won_T;//玩家人數，地圖，勝利條件
        int HouseX, HouseY;
        Anime Anime;//動畫視窗
        System.Media.SoundPlayer ClickS;//按鈕音效

        /*遊戲資料*/
        public Point[] MLocation;//座標
        public String[] MName;//地圖名字
        public int[] MPlace;//地點(土地、機會命運、特殊地點)
        public int[] MOwner;//土地擁有者   
        public int[] Mvalue;//土地價值
        public int Mamount;//地圖格數
        public int Round;//目前回合
        public PictureBox[] CharacterHead;//角色頭貼
        public Label[] CharacterName;//角色名字
        public Label[] CharacterInfo;//角色訊息
        public PictureBox[] Pieces;//棋子
        public Character []Character;//角色資料      
       
        private void ReadGame()
        {
            String[] tmp;           
            Random random = new Random();           
            /*動畫視窗*/
            Anime = new Anime();
            Anime.Visible = false;
            HouseX = HouseY = 30;

            /*音效*/
            ClickS = new System.Media.SoundPlayer();
            ClickS.SoundLocation= System.Windows.Forms.Application.StartupPath + @"\Data\Sound\Click.wav";
            BGM.URL= (System.Windows.Forms.Application.StartupPath + @"\Data\Sound\BGM.wav");
            BGM.settings.setMode("loop", true);


            /*讀取資料*/
            BigMap.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\Data\Image\Map_"+nMap+".png");
            StreamReader Data = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\Data\MapData_" + nMap + ".txt", Encoding.Default);
            int Money = Convert.ToInt32(Data.ReadLine());

            /*載入地圖資料*/
            Mamount = Convert.ToInt32(Data.ReadLine());//地圖格數
            MLocation = new Point[Mamount];
            MName = new String[Mamount];
            MPlace = new int[Mamount];
            MOwner = new int[Mamount];
            Mvalue = new int[Mamount];            
                      
            for (int i = 0; i < Mamount; i++)
            {
                tmp = Data.ReadLine().Split(new char[] { ':' });
                if (Convert.ToInt32(tmp[0]) == 1)
                    Mvalue[i] = 2000 + random.Next(0, 30) * 100;//產生土地價錢(2000~5000:每單位100)
                else
                    Mvalue[i] = -1;
                MPlace[i] = Convert.ToInt32(tmp[0]);//格子類型
                MLocation[i] = new Point(Convert.ToInt32(tmp[1]), Convert.ToInt32(tmp[2]));//座標
                MName[i] = tmp[3];//地點名稱
                MOwner[i] = -1;//預設土地無人擁有
            }
            Data.Close();

            /*載入角色*/
            Character = new Character[nPlayer];//玩家人數
            CharacterHead = new PictureBox[] { CharacterHead1, CharacterHead2, CharacterHead3, CharacterHead4 };
            CharacterName = new Label[] { CharacterName1, CharacterName2, CharacterName3, CharacterName4 };
            CharacterInfo = new Label[] { CharacterInfo1, CharacterInfo2, CharacterInfo3, CharacterInfo4 };
            Pieces = new PictureBox[] { Pieces1, Pieces2, Pieces3, Pieces4 };

            for (int i = 0; i < nPlayer; i++)
            {
                /*初始化角色*/
                Character[i] = new Character();
                Character[i].Preset(Money, Mamount);//預設角色現金10萬

                /*初始化角色訊息*/
                CharacterHead[i].Visible = true;
                CharacterName[i].Visible = true;
                CharacterInfo[i].Visible = true;
                ReInfo(i);

                /*初始化棋子*/
                Pieces[i].Visible = true;
                Pieces[i].Location = MLocation[0];
                this.BigMap.Controls.Add(Pieces[i]);
            }   
            //nPlayer = 1;//測試，1位角色
            Round = random.Next(0, nPlayer);//隨機開始遊戲
            label1.Text = CharacterName[Round].Text+"，開始";//測試，確認數值
        }
        private async void Roll_Click(object sender, EventArgs e)
        {
            /*移動位置*/
            Roll.Enabled = false;
            Random random = new Random();
            int ROLLDICE = 0;
            ROLLDICE = random.Next(1, 7);
            Anime.Play("Anime\\Roll_"+ROLLDICE + ".gif", "Sound\\ROLL.wav", 1500);
            label1.Text = CharacterName[Round].Text + "，移動了" + (ROLLDICE * Character[Round].Dice) + "步";
            Character[Round].RollDice(Mamount, ROLLDICE);
            Pieces[Round].Location = MLocation[Character[Round].Place];            
            ReInfo(Round);
            await Task.Delay(1550);
            Drop_Place(Character[Round].Place);            
        }           
        private void BuyCar_Click(object sender, EventArgs e)
        {
            ClickS.Play();
            /*購買交通工具*/
            if (BScooter.Checked)
            {
                DialogResult result = MessageBox.Show("金額為：1000", "是否租用機車?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Character[Round].ChangeMoney(-1000);
                    Character[Round].Dice += 1;
                }
            }
            else if (BCar.Checked)
            {
                DialogResult result = MessageBox.Show("金額為：3000", "是否租用汽車?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Character[Round].ChangeMoney(-3000);
                    Character[Round].Dice += 2;
                }
            }
            ReInfo(Round);
            BuyTraffic.Enabled = false;
        }
        private void Next()
        {
            /*下一位玩家*/
            Round = (Round + 1) % nPlayer;
            while (Character[Round].CheckPass())
            {
                //檢查下一位是否Pass或破產
                Round = (Round + 1) % nPlayer;
            }
            label1.Text = CharacterName[Round].Text + "，等待擲骰";
            CheckWon();
            if (Character[Round].Dice == 1)
                BuyTraffic.Enabled = true;
            Roll.Enabled = true;
        }
        private async void Drop_Place(int N)
        {
            /*判斷落點*/
            int Place = MPlace[N];
            switch (Place)
            {
                case 0://踩到起點加1000
                    Character[Round].ChangeMoney(1000);
                    ReInfo(Round);
                    break;

                case 1://土地
                    Estate(N);
                    await Task.Delay(650);
                    break;

                case 2://機會
                    if (Opportunity())
                    {
                        Drop_Place(Character[Round].Place);
                        return;
                    }
                    break;

                case 3://命運
                    if (Opportunity())
                    {
                        Drop_Place(Character[Round].Place);
                        return;
                    }
                    break;

                case 4://監獄
                    Anime.Play("Anime\\Jail.gif", "Sound\\Jail.wav", 1000);
                    Character[Round].Jail(1);
                    Character[Round].ChangeMoney(-1000);
                    ReInfo(Round);
                    break;

                case 5://特殊
                    Anime.Play("Anime\\Hospital.gif", "Sound\\Hospital.wav", 500);
                    Character[Round].Dice ++;
                    Character[Round].ChangeMoney(-500);
                    ReInfo(Round);
                    break;

                default://找不到地點回傳錯誤
                    MessageBox.Show("Error!!");
                    break;
            }
            if (!Die())
            {
                Next();
            }
        }
        private void sellEstate_Click(object sender, EventArgs e)
        {
            ClickS.Play();
            int count = 0;
            for (int i = 1; i < Mamount; i++)
            {
                if (MOwner[i] == Round)
                {
                    if (ownEstate.GetItemChecked(count))
                    {
                        Character[Round].ChangeMoney(Character[Round].Land[i] * Mvalue[i]);
                        Character[Round].Land[i] = 0;
                        MOwner[i] = -1;
                    }
                    count++;
                }
            }
            ReInfo(Round);
            Bankrupt.Visible = false;
            BigMap.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\Data\Image\Map_" + nMap + ".png");
            if (!Die())
            {
                Next();
            }
        }
        private void Estate(int N)
        {
            if (MOwner[N] == -1)
            {
                /*購買無人土地*/
                if (Character[Round].Money <= Mvalue[N]) return;
                DialogResult result = MessageBox.Show("金額為：" + Mvalue[N], "是否購買"+MName[N]+"?", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {                                    
                    Anime.Play("Anime\\Buy.gif", "Sound\\Pay.wav", 600);
                    Character[Round].BuyEstate(N, Mvalue[N]);
                    MOwner[N] = Round;
                    ReInfo(Round);
                    House();
                }
            }
            else if (MOwner[N] == Round)
            {
                /*升級地產*/
                if (Character[Round].Money <= Mvalue[N]) return;
                DialogResult result = MessageBox.Show(MName[N]+"升級費用為：" + Mvalue[N], "是否升級?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Anime.Play("Anime\\Upgrade.gif", "Sound\\Pay.wav", 600);
                    Character[Round].BuyEstate(N, Mvalue[N]);
                    ReInfo(Round);
                    House();
                }
            }
            else
            {
                /*踩到其他玩家的土地*/
                int Tolls = Mvalue[N] * Character[MOwner[N]].Land[N];
                Character[Round].ChangeMoney(-(Tolls));
                Character[MOwner[N]].ChangeMoney(Tolls);
                MessageBox.Show(MName[N]+"過路費：" + Tolls + "\n給" + CharacterName[MOwner[N]].Text,"繳交過路費");
                Anime.Play("Anime\\Pay.gif", "Sound\\Pay.wav", 600);
                ReInfo(Round);
                ReInfo(MOwner[N]);
            }
        }
        private bool Opportunity()
        {
            /*機會命運*/
            StreamReader OppData = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\Data\Opportunity.txt", Encoding.Default);
            Random random = new Random();
            String[] tmp = null;
            bool opp = false;
            int max = Convert.ToInt32(OppData.ReadLine());
            int Pump = random.Next(1, max + 1);//抽籤，目前有16種機會命運
            for(int i = 0; i < Pump; i++)
            {
                tmp = OppData.ReadLine().Split(new char[] { ':' });
            }
            OppData.Close();
            MessageBox.Show(tmp[5], tmp[4]);
            if (Convert.ToInt32(tmp[0]) == 3)
            {                
                int Move = 0;
                for (int j = 0; j < Mamount; j++)
                {
                    if (Convert.ToInt32(tmp[3]) == MPlace[j])
                        Move = j;
                }
                Character[Round].Place = Move;
                Pieces[Round].Location = MLocation[Move];
                ReInfo(Round);
                opp = true;
            }
            if (Convert.ToInt32(tmp[0]) == 2)
            {
                int Move = 0;
                for (int j = 0; j < Mamount; j++)
                {
                    if (Convert.ToInt32(tmp[3]) == MPlace[j])
                        Move = j;
                }
                Character[Round].Place = Move;
                Pieces[Round].Location = MLocation[Move];
                ReInfo(Round);
                tmp[0] = "1";
                opp = true;
            }
            if (Convert.ToInt32(tmp[0]) == 1)
            {
                Character[Round].Jail(Convert.ToInt32(tmp[2]));
                tmp[0] = "0";
            }
            if (Convert.ToInt32(tmp[0]) == 0)
            {
                Character[Round].ChangeMoney(Convert.ToInt32(tmp[1]));
                ReInfo(Round);
            }
            return opp;
        }
        private bool Die()
        {
            /*確認破產*/
            if (Character[Round].Money <= 0)
            {
                ownEstate.Items.Clear();
                bool Have = false;
                for(int i = 1; i < Mamount; i++)
                {
                    /*列出玩家擁有的資產*/
                    if (MOwner[i] == Round)
                    {
                        ownEstate.Items.Add(MName[i] + "：" + Mvalue[i] * Character[Round].Land[i]+"元");
                        Have=true;
                    }
                }

                if (Have)
                {
                    MessageBox.Show("您的資金用完了，請販售資產!");
                    Bankrupt.Visible = true;
                }
                else
                {
                    MessageBox.Show("破產!");
                    Character[Round].Die = true;
                    Pieces[Round].Visible = false;
                    CharacterInfo[Round].Text = "破產";
                    Won_P--;
                    Next();
                }
                return true;
            }
            return false;
        }
        private void CheckWon()
        {
            /*確認贏家*/
            if (Won_P == 1)
            {
                MessageBox.Show(CharacterName[Round].Text + "勝利!!");
                Application.Exit();
            }
            if (Won_T == 0)
            {
                GameTimer.Stop();
                int tmp=-1;
                int WhoWon=-1;

                for(int i = 0; i < nPlayer; i++)
                {
                    int AllMoney = Character[i].Money;
                    for (int j = 1; j < Mamount; j++)
                        AllMoney += Character[i].Land[j] * Mvalue[j];                    
                    if (tmp < AllMoney)
                    {
                        tmp = AllMoney;
                        WhoWon = i;
                    }
                }
                MessageBox.Show(CharacterName[WhoWon].Text + "勝利!!");
                Application.Exit();
            }
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Won_T--;
            TIMER.Text = "剩餘" + Won_T + "分鐘";
            CheckWon();
        }
        private void ReInfo(int R)
        {
            /*更新資訊*/
            int AllMoney = Character[R].Money;
            for (int i = 1; i < Mamount; i++)
                AllMoney += Character[R].Land[i] * Mvalue[i];
            CharacterInfo[R].Text = "目前資金\n" + Character[R].Money + "\n總資產\n" + AllMoney +
                                    "\n所在地\n" + MName[Character[R].Place] + "\n骰子倍率\n(";
            if (Character[R].Pass > 0)
            {
                CharacterInfo[R].Text += "暫停中)";
            }
            else
                CharacterInfo[R].Text += Character[R].Dice + ")";
        }
        private void BigMap_Paint(object sender, PaintEventArgs e)
        {
            House();
        }
        private void House()
        {
            Graphics Draw = BigMap.CreateGraphics();            
            for(int i = 0; i < Mamount; i++)
            {
                if (MOwner[i] != -1)
                {
                    Image house = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\Data\Image\House_" + (MOwner[i] + 1) + ".png");
                    Draw.DrawImage(house, MLocation[i].X, MLocation[i].Y, HouseX, HouseY);
                    Draw.DrawString(Character[MOwner[i]].Land[i].ToString(), new Font("超世紀中勘亭", 20, FontStyle.Bold),
                                    new SolidBrush(Color.Black), MLocation[i].X, MLocation[i].Y);
                }
            }
        }
    }
    public class Character
    {
        /*角色資料*/
        public bool Die;//破產
        public int Pass;//暫停回合
        public int Money;//金錢
        public int Dice;//骰子數
        public int Place;//目前位置
        public int[] Land;//擁有土地
        public Character(){
            Die = false;
            Pass = -1;
            Money = -1;
            Dice = -1;
            Place = -1;
            Land = null;
        }          
        public void Preset(int M,int Mamount)
        {
            /*創建角色*/
            Die = false;
            Pass = 0;
            Money = M;
            Dice = 1;
            Place = 0;
            Land = new int[Mamount];
            for (int i = 0; i < Mamount; i++)
                Land[i] = 0;
        }
        public void RollDice(int Mamount,int roll)
        {
            /*擲骰子*/
            Place = (Place + roll * Dice) % Mamount;
            if (Dice > 1) Dice--;            
        }
        public int ChangeMoney(int M)
        {
            /*改變金錢*/
            Money += M;            
            return Money;
        }
        public void BuyEstate(int N,int M)
        {
            /*購買地產*/
            Land[N]++;
            ChangeMoney(-M);
        }       
        public void Jail(int R)
        {
            /*入獄*/
            Pass = R;
        }
        public bool CheckPass()
        {
            /*確認是否略過*/
            if (Die == true)
            {
                return true;
            }
            else if (Pass > 0)
            {
                Pass--;
                return true;
            }
            return false;
        }
    }   
}