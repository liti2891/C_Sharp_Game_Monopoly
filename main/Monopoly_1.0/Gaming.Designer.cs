namespace Monopoly_1._0
{
    partial class Gaming
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gaming));
            this.BigMap = new System.Windows.Forms.PictureBox();
            this.Pieces1 = new System.Windows.Forms.PictureBox();
            this.Roll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pieces2 = new System.Windows.Forms.PictureBox();
            this.Pieces3 = new System.Windows.Forms.PictureBox();
            this.Pieces4 = new System.Windows.Forms.PictureBox();
            this.CharacterHead1 = new System.Windows.Forms.PictureBox();
            this.CharacterHead2 = new System.Windows.Forms.PictureBox();
            this.CharacterHead4 = new System.Windows.Forms.PictureBox();
            this.CharacterHead3 = new System.Windows.Forms.PictureBox();
            this.CharacterName1 = new System.Windows.Forms.Label();
            this.CharacterName2 = new System.Windows.Forms.Label();
            this.CharacterName4 = new System.Windows.Forms.Label();
            this.CharacterName3 = new System.Windows.Forms.Label();
            this.CharacterInfo1 = new System.Windows.Forms.Label();
            this.CharacterInfo2 = new System.Windows.Forms.Label();
            this.CharacterInfo4 = new System.Windows.Forms.Label();
            this.CharacterInfo3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Bankrupt = new System.Windows.Forms.GroupBox();
            this.sellEstate = new System.Windows.Forms.Button();
            this.ownEstate = new System.Windows.Forms.CheckedListBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.TIMER = new System.Windows.Forms.Label();
            this.BuyTraffic = new System.Windows.Forms.GroupBox();
            this.BCar = new System.Windows.Forms.RadioButton();
            this.BScooter = new System.Windows.Forms.RadioButton();
            this.Car = new System.Windows.Forms.PictureBox();
            this.Scooter = new System.Windows.Forms.PictureBox();
            this.BuyCar = new System.Windows.Forms.Button();
            this.BGM = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.BigMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pieces1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pieces2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pieces3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pieces4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHead1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHead2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHead4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHead3)).BeginInit();
            this.Bankrupt.SuspendLayout();
            this.BuyTraffic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGM)).BeginInit();
            this.SuspendLayout();
            // 
            // BigMap
            // 
            this.BigMap.BackColor = System.Drawing.Color.DimGray;
            this.BigMap.Image = ((System.Drawing.Image)(resources.GetObject("BigMap.Image")));
            this.BigMap.Location = new System.Drawing.Point(112, 43);
            this.BigMap.Name = "BigMap";
            this.BigMap.Size = new System.Drawing.Size(800, 600);
            this.BigMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigMap.TabIndex = 0;
            this.BigMap.TabStop = false;
            this.BigMap.Paint += new System.Windows.Forms.PaintEventHandler(this.BigMap_Paint);
            // 
            // Pieces1
            // 
            this.Pieces1.BackColor = System.Drawing.Color.Transparent;
            this.Pieces1.Image = ((System.Drawing.Image)(resources.GetObject("Pieces1.Image")));
            this.Pieces1.Location = new System.Drawing.Point(112, 43);
            this.Pieces1.Name = "Pieces1";
            this.Pieces1.Size = new System.Drawing.Size(40, 40);
            this.Pieces1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pieces1.TabIndex = 1;
            this.Pieces1.TabStop = false;
            this.Pieces1.Visible = false;
            // 
            // Roll
            // 
            this.Roll.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Roll.Location = new System.Drawing.Point(442, 671);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(140, 66);
            this.Roll.TabIndex = 2;
            this.Roll.Text = "擲骰子";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "狀態列";
            // 
            // Pieces2
            // 
            this.Pieces2.BackColor = System.Drawing.Color.Transparent;
            this.Pieces2.Image = ((System.Drawing.Image)(resources.GetObject("Pieces2.Image")));
            this.Pieces2.Location = new System.Drawing.Point(112, 43);
            this.Pieces2.Name = "Pieces2";
            this.Pieces2.Size = new System.Drawing.Size(40, 40);
            this.Pieces2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pieces2.TabIndex = 4;
            this.Pieces2.TabStop = false;
            this.Pieces2.Visible = false;
            // 
            // Pieces3
            // 
            this.Pieces3.BackColor = System.Drawing.Color.Transparent;
            this.Pieces3.Image = ((System.Drawing.Image)(resources.GetObject("Pieces3.Image")));
            this.Pieces3.Location = new System.Drawing.Point(112, 43);
            this.Pieces3.Name = "Pieces3";
            this.Pieces3.Size = new System.Drawing.Size(40, 40);
            this.Pieces3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pieces3.TabIndex = 5;
            this.Pieces3.TabStop = false;
            this.Pieces3.Visible = false;
            // 
            // Pieces4
            // 
            this.Pieces4.BackColor = System.Drawing.Color.Transparent;
            this.Pieces4.Image = ((System.Drawing.Image)(resources.GetObject("Pieces4.Image")));
            this.Pieces4.Location = new System.Drawing.Point(112, 43);
            this.Pieces4.Name = "Pieces4";
            this.Pieces4.Size = new System.Drawing.Size(40, 40);
            this.Pieces4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pieces4.TabIndex = 6;
            this.Pieces4.TabStop = false;
            this.Pieces4.Visible = false;
            // 
            // CharacterHead1
            // 
            this.CharacterHead1.BackColor = System.Drawing.Color.White;
            this.CharacterHead1.Image = ((System.Drawing.Image)(resources.GetObject("CharacterHead1.Image")));
            this.CharacterHead1.Location = new System.Drawing.Point(12, 43);
            this.CharacterHead1.Name = "CharacterHead1";
            this.CharacterHead1.Size = new System.Drawing.Size(100, 100);
            this.CharacterHead1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CharacterHead1.TabIndex = 7;
            this.CharacterHead1.TabStop = false;
            this.CharacterHead1.Visible = false;
            // 
            // CharacterHead2
            // 
            this.CharacterHead2.BackColor = System.Drawing.Color.White;
            this.CharacterHead2.Image = ((System.Drawing.Image)(resources.GetObject("CharacterHead2.Image")));
            this.CharacterHead2.Location = new System.Drawing.Point(912, 43);
            this.CharacterHead2.Name = "CharacterHead2";
            this.CharacterHead2.Size = new System.Drawing.Size(100, 100);
            this.CharacterHead2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CharacterHead2.TabIndex = 8;
            this.CharacterHead2.TabStop = false;
            this.CharacterHead2.Visible = false;
            // 
            // CharacterHead4
            // 
            this.CharacterHead4.BackColor = System.Drawing.Color.White;
            this.CharacterHead4.Image = ((System.Drawing.Image)(resources.GetObject("CharacterHead4.Image")));
            this.CharacterHead4.Location = new System.Drawing.Point(12, 351);
            this.CharacterHead4.Name = "CharacterHead4";
            this.CharacterHead4.Size = new System.Drawing.Size(100, 100);
            this.CharacterHead4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CharacterHead4.TabIndex = 9;
            this.CharacterHead4.TabStop = false;
            this.CharacterHead4.Visible = false;
            // 
            // CharacterHead3
            // 
            this.CharacterHead3.BackColor = System.Drawing.Color.White;
            this.CharacterHead3.Image = ((System.Drawing.Image)(resources.GetObject("CharacterHead3.Image")));
            this.CharacterHead3.Location = new System.Drawing.Point(912, 351);
            this.CharacterHead3.Name = "CharacterHead3";
            this.CharacterHead3.Size = new System.Drawing.Size(100, 100);
            this.CharacterHead3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CharacterHead3.TabIndex = 10;
            this.CharacterHead3.TabStop = false;
            this.CharacterHead3.Visible = false;
            // 
            // CharacterName1
            // 
            this.CharacterName1.AutoSize = true;
            this.CharacterName1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterName1.Location = new System.Drawing.Point(12, 146);
            this.CharacterName1.Name = "CharacterName1";
            this.CharacterName1.Size = new System.Drawing.Size(79, 21);
            this.CharacterName1.TabIndex = 11;
            this.CharacterName1.Text = "李逍遙";
            this.CharacterName1.Visible = false;
            // 
            // CharacterName2
            // 
            this.CharacterName2.AutoSize = true;
            this.CharacterName2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterName2.Location = new System.Drawing.Point(918, 146);
            this.CharacterName2.Name = "CharacterName2";
            this.CharacterName2.Size = new System.Drawing.Size(79, 21);
            this.CharacterName2.TabIndex = 12;
            this.CharacterName2.Text = "趙靈兒";
            this.CharacterName2.Visible = false;
            // 
            // CharacterName4
            // 
            this.CharacterName4.AutoSize = true;
            this.CharacterName4.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterName4.Location = new System.Drawing.Point(21, 454);
            this.CharacterName4.Name = "CharacterName4";
            this.CharacterName4.Size = new System.Drawing.Size(56, 21);
            this.CharacterName4.TabIndex = 13;
            this.CharacterName4.Text = "阿奴";
            this.CharacterName4.Visible = false;
            // 
            // CharacterName3
            // 
            this.CharacterName3.AutoSize = true;
            this.CharacterName3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterName3.Location = new System.Drawing.Point(918, 454);
            this.CharacterName3.Name = "CharacterName3";
            this.CharacterName3.Size = new System.Drawing.Size(79, 21);
            this.CharacterName3.TabIndex = 14;
            this.CharacterName3.Text = "林月如";
            this.CharacterName3.Visible = false;
            // 
            // CharacterInfo1
            // 
            this.CharacterInfo1.AutoSize = true;
            this.CharacterInfo1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CharacterInfo1.Location = new System.Drawing.Point(5, 167);
            this.CharacterInfo1.Name = "CharacterInfo1";
            this.CharacterInfo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CharacterInfo1.Size = new System.Drawing.Size(98, 168);
            this.CharacterInfo1.TabIndex = 15;
            this.CharacterInfo1.Text = "目前資金\r\n0\r\n總資產\r\n0\r\n所在地\r\n起點\r\n骰子數\r\n1";
            this.CharacterInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CharacterInfo1.Visible = false;
            // 
            // CharacterInfo2
            // 
            this.CharacterInfo2.AutoSize = true;
            this.CharacterInfo2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CharacterInfo2.Location = new System.Drawing.Point(914, 167);
            this.CharacterInfo2.Name = "CharacterInfo2";
            this.CharacterInfo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CharacterInfo2.Size = new System.Drawing.Size(98, 168);
            this.CharacterInfo2.TabIndex = 16;
            this.CharacterInfo2.Text = "目前資金\r\n0\r\n總資產\r\n0\r\n所在地\r\n起點\r\n骰子數\r\n1";
            this.CharacterInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CharacterInfo2.Visible = false;
            // 
            // CharacterInfo4
            // 
            this.CharacterInfo4.AutoSize = true;
            this.CharacterInfo4.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterInfo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CharacterInfo4.Location = new System.Drawing.Point(5, 475);
            this.CharacterInfo4.Name = "CharacterInfo4";
            this.CharacterInfo4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CharacterInfo4.Size = new System.Drawing.Size(98, 168);
            this.CharacterInfo4.TabIndex = 17;
            this.CharacterInfo4.Text = "目前資金\r\n0\r\n總資產\r\n0\r\n所在地\r\n起點\r\n骰子數\r\n1";
            this.CharacterInfo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CharacterInfo4.Visible = false;
            // 
            // CharacterInfo3
            // 
            this.CharacterInfo3.AutoSize = true;
            this.CharacterInfo3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CharacterInfo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CharacterInfo3.Location = new System.Drawing.Point(914, 475);
            this.CharacterInfo3.Name = "CharacterInfo3";
            this.CharacterInfo3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CharacterInfo3.Size = new System.Drawing.Size(98, 168);
            this.CharacterInfo3.TabIndex = 18;
            this.CharacterInfo3.Text = "目前資金\r\n0\r\n總資產\r\n0\r\n所在地\r\n起點\r\n骰子數\r\n1";
            this.CharacterInfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CharacterInfo3.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(950, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "退出遊戲";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Bankrupt
            // 
            this.Bankrupt.Controls.Add(this.sellEstate);
            this.Bankrupt.Controls.Add(this.ownEstate);
            this.Bankrupt.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bankrupt.Location = new System.Drawing.Point(342, 242);
            this.Bankrupt.Name = "Bankrupt";
            this.Bankrupt.Size = new System.Drawing.Size(223, 117);
            this.Bankrupt.TabIndex = 20;
            this.Bankrupt.TabStop = false;
            this.Bankrupt.Text = "販售 資產";
            this.Bankrupt.Visible = false;
            // 
            // sellEstate
            // 
            this.sellEstate.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sellEstate.Location = new System.Drawing.Point(56, 88);
            this.sellEstate.Name = "sellEstate";
            this.sellEstate.Size = new System.Drawing.Size(112, 23);
            this.sellEstate.TabIndex = 1;
            this.sellEstate.Text = "確定販售";
            this.sellEstate.UseVisualStyleBackColor = true;
            this.sellEstate.Click += new System.EventHandler(this.sellEstate_Click);
            // 
            // ownEstate
            // 
            this.ownEstate.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ownEstate.FormattingEnabled = true;
            this.ownEstate.Location = new System.Drawing.Point(6, 26);
            this.ownEstate.Name = "ownEstate";
            this.ownEstate.Size = new System.Drawing.Size(211, 58);
            this.ownEstate.TabIndex = 0;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 60000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // TIMER
            // 
            this.TIMER.AutoSize = true;
            this.TIMER.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TIMER.Location = new System.Drawing.Point(436, 8);
            this.TIMER.Name = "TIMER";
            this.TIMER.Size = new System.Drawing.Size(0, 32);
            this.TIMER.TabIndex = 21;
            // 
            // BuyTraffic
            // 
            this.BuyTraffic.Controls.Add(this.BCar);
            this.BuyTraffic.Controls.Add(this.BScooter);
            this.BuyTraffic.Controls.Add(this.Car);
            this.BuyTraffic.Controls.Add(this.Scooter);
            this.BuyTraffic.Controls.Add(this.BuyCar);
            this.BuyTraffic.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BuyTraffic.Location = new System.Drawing.Point(608, 649);
            this.BuyTraffic.Name = "BuyTraffic";
            this.BuyTraffic.Size = new System.Drawing.Size(304, 117);
            this.BuyTraffic.TabIndex = 21;
            this.BuyTraffic.TabStop = false;
            this.BuyTraffic.Text = "購買交通工具";
            // 
            // BCar
            // 
            this.BCar.AutoSize = true;
            this.BCar.Location = new System.Drawing.Point(225, 75);
            this.BCar.Name = "BCar";
            this.BCar.Size = new System.Drawing.Size(14, 13);
            this.BCar.TabIndex = 5;
            this.BCar.TabStop = true;
            this.BCar.UseVisualStyleBackColor = true;
            // 
            // BScooter
            // 
            this.BScooter.AutoSize = true;
            this.BScooter.Location = new System.Drawing.Point(67, 75);
            this.BScooter.Name = "BScooter";
            this.BScooter.Size = new System.Drawing.Size(14, 13);
            this.BScooter.TabIndex = 4;
            this.BScooter.TabStop = true;
            this.BScooter.UseVisualStyleBackColor = true;
            // 
            // Car
            // 
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(187, 22);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(83, 49);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 3;
            this.Car.TabStop = false;
            // 
            // Scooter
            // 
            this.Scooter.Image = ((System.Drawing.Image)(resources.GetObject("Scooter.Image")));
            this.Scooter.Location = new System.Drawing.Point(32, 22);
            this.Scooter.Name = "Scooter";
            this.Scooter.Size = new System.Drawing.Size(83, 49);
            this.Scooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Scooter.TabIndex = 2;
            this.Scooter.TabStop = false;
            // 
            // BuyCar
            // 
            this.BuyCar.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BuyCar.Location = new System.Drawing.Point(91, 88);
            this.BuyCar.Name = "BuyCar";
            this.BuyCar.Size = new System.Drawing.Size(112, 23);
            this.BuyCar.TabIndex = 1;
            this.BuyCar.Text = "確定購買";
            this.BuyCar.UseVisualStyleBackColor = true;
            this.BuyCar.Click += new System.EventHandler(this.BuyCar_Click);
            // 
            // BGM
            // 
            this.BGM.Enabled = true;
            this.BGM.Location = new System.Drawing.Point(9, 8);
            this.BGM.Name = "BGM";
            this.BGM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BGM.OcxState")));
            this.BGM.Size = new System.Drawing.Size(8, 8);
            this.BGM.TabIndex = 22;
            this.BGM.Visible = false;
            // 
            // Gaming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.BGM);
            this.Controls.Add(this.BuyTraffic);
            this.Controls.Add(this.TIMER);
            this.Controls.Add(this.Bankrupt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CharacterInfo3);
            this.Controls.Add(this.CharacterInfo4);
            this.Controls.Add(this.CharacterInfo2);
            this.Controls.Add(this.CharacterInfo1);
            this.Controls.Add(this.CharacterName3);
            this.Controls.Add(this.CharacterName4);
            this.Controls.Add(this.CharacterName2);
            this.Controls.Add(this.CharacterHead3);
            this.Controls.Add(this.CharacterHead4);
            this.Controls.Add(this.CharacterHead2);
            this.Controls.Add(this.CharacterHead1);
            this.Controls.Add(this.Pieces1);
            this.Controls.Add(this.Pieces2);
            this.Controls.Add(this.Pieces3);
            this.Controls.Add(this.Pieces4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.BigMap);
            this.Controls.Add(this.CharacterName1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Gaming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大富翁1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gaming_FormClosed);
            this.Load += new System.EventHandler(this.Gaming_Load);
            this.Resize += new System.EventHandler(this.Gaming_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BigMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pieces1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pieces2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pieces3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pieces4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHead1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHead2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHead4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHead3)).EndInit();
            this.Bankrupt.ResumeLayout(false);
            this.BuyTraffic.ResumeLayout(false);
            this.BuyTraffic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BigMap;
        private System.Windows.Forms.PictureBox Pieces1;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pieces2;
        private System.Windows.Forms.PictureBox Pieces3;
        private System.Windows.Forms.PictureBox Pieces4;
        private System.Windows.Forms.PictureBox CharacterHead1;
        private System.Windows.Forms.PictureBox CharacterHead2;
        private System.Windows.Forms.PictureBox CharacterHead4;
        private System.Windows.Forms.PictureBox CharacterHead3;
        private System.Windows.Forms.Label CharacterName1;
        private System.Windows.Forms.Label CharacterName2;
        private System.Windows.Forms.Label CharacterName4;
        private System.Windows.Forms.Label CharacterName3;
        private System.Windows.Forms.Label CharacterInfo1;
        private System.Windows.Forms.Label CharacterInfo2;
        private System.Windows.Forms.Label CharacterInfo4;
        private System.Windows.Forms.Label CharacterInfo3;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox Bankrupt;
        private System.Windows.Forms.Button sellEstate;
        private System.Windows.Forms.CheckedListBox ownEstate;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label TIMER;
        private System.Windows.Forms.GroupBox BuyTraffic;
        private System.Windows.Forms.RadioButton BCar;
        private System.Windows.Forms.RadioButton BScooter;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox Scooter;
        private System.Windows.Forms.Button BuyCar;
        private AxWMPLib.AxWindowsMediaPlayer BGM;
    }
}