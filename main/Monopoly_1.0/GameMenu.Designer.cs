namespace Monopoly_1._0
{
    partial class GameMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GameStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sVictory = new System.Windows.Forms.ComboBox();
            this.sPlayer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sMap = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GameStart
            // 
            this.GameStart.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GameStart.Location = new System.Drawing.Point(26, 91);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(200, 80);
            this.GameStart.TabIndex = 0;
            this.GameStart.Text = "遊戲開始";
            this.GameStart.UseVisualStyleBackColor = true;
            this.GameStart.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "勝利條件";
            // 
            // sVictory
            // 
            this.sVictory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sVictory.FormattingEnabled = true;
            this.sVictory.Items.AddRange(new object[] {
            "剩餘1人",
            "計時10分鐘"});
            this.sVictory.Location = new System.Drawing.Point(127, 65);
            this.sVictory.Name = "sVictory";
            this.sVictory.Size = new System.Drawing.Size(109, 20);
            this.sVictory.TabIndex = 11;
            // 
            // sPlayer
            // 
            this.sPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPlayer.FormattingEnabled = true;
            this.sPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sPlayer.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.sPlayer.Location = new System.Drawing.Point(127, 13);
            this.sPlayer.Name = "sPlayer";
            this.sPlayer.Size = new System.Drawing.Size(109, 20);
            this.sPlayer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(63, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "地圖";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "玩家人數";
            // 
            // sMap
            // 
            this.sMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sMap.FormattingEnabled = true;
            this.sMap.Items.AddRange(new object[] {
            "小",
            "大"});
            this.sMap.Location = new System.Drawing.Point(127, 39);
            this.sMap.Name = "sMap";
            this.sMap.Size = new System.Drawing.Size(109, 20);
            this.sMap.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(182, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "全螢幕";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 194);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sVictory);
            this.Controls.Add(this.sPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sMap);
            this.Controls.Add(this.GameStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大富翁1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sVictory;
        private System.Windows.Forms.ComboBox sPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sMap;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

