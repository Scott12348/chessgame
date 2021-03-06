namespace Chess_Programming
{
    partial class frmGameOptions
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
            this.grOptionGame = new System.Windows.Forms.GroupBox();
            this.cboUndo = new System.Windows.Forms.ComboBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cboExtraTimer = new System.Windows.Forms.ComboBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cboMoveTimer = new System.Windows.Forms.ComboBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboTotalTimer = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.button1 = new DevComponents.DotNetBar.ButtonX();
            this.grOptionGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grOptionGame
            // 
            this.grOptionGame.Controls.Add(this.cboUndo);
            this.grOptionGame.Controls.Add(this.labelX7);
            this.grOptionGame.Controls.Add(this.labelX8);
            this.grOptionGame.Controls.Add(this.cboExtraTimer);
            this.grOptionGame.Controls.Add(this.labelX6);
            this.grOptionGame.Controls.Add(this.cboMoveTimer);
            this.grOptionGame.Controls.Add(this.labelX5);
            this.grOptionGame.Controls.Add(this.labelX3);
            this.grOptionGame.Controls.Add(this.cboTotalTimer);
            this.grOptionGame.Controls.Add(this.labelX2);
            this.grOptionGame.Controls.Add(this.labelX4);
            this.grOptionGame.Controls.Add(this.labelX1);
            this.grOptionGame.Controls.Add(this.pictureBox2);
            this.grOptionGame.Controls.Add(this.pictureBox1);
            this.grOptionGame.Controls.Add(this.radWhite);
            this.grOptionGame.Controls.Add(this.radBlack);
            this.grOptionGame.Enabled = false;
            this.grOptionGame.Location = new System.Drawing.Point(14, 22);
            this.grOptionGame.Margin = new System.Windows.Forms.Padding(5);
            this.grOptionGame.Name = "grOptionGame";
            this.grOptionGame.Padding = new System.Windows.Forms.Padding(5);
            this.grOptionGame.Size = new System.Drawing.Size(315, 294);
            this.grOptionGame.TabIndex = 12;
            this.grOptionGame.TabStop = false;
            this.grOptionGame.Text = "Tùy Chọn Trò Chơi";
            // 
            // cboUndo
            // 
            this.cboUndo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUndo.FormattingEnabled = true;
            this.cboUndo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboUndo.Location = new System.Drawing.Point(160, 246);
            this.cboUndo.Name = "cboUndo";
            this.cboUndo.Size = new System.Drawing.Size(92, 24);
            this.cboUndo.TabIndex = 18;
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(270, 245);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(70, 23);
            this.labelX7.TabIndex = 19;
            this.labelX7.Text = "lần";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Location = new System.Drawing.Point(8, 248);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(102, 18);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "Số lần được đi lại";
            // 
            // cboExtraTimer
            // 
            this.cboExtraTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExtraTimer.FormattingEnabled = true;
            this.cboExtraTimer.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboExtraTimer.Location = new System.Drawing.Point(160, 217);
            this.cboExtraTimer.Name = "cboExtraTimer";
            this.cboExtraTimer.Size = new System.Drawing.Size(92, 24);
            this.cboExtraTimer.TabIndex = 15;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(270, 217);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(70, 23);
            this.labelX6.TabIndex = 16;
            this.labelX6.Text = "giây";
            // 
            // cboMoveTimer
            // 
            this.cboMoveTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoveTimer.FormattingEnabled = true;
            this.cboMoveTimer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboMoveTimer.Location = new System.Drawing.Point(160, 188);
            this.cboMoveTimer.Name = "cboMoveTimer";
            this.cboMoveTimer.Size = new System.Drawing.Size(92, 24);
            this.cboMoveTimer.TabIndex = 13;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(270, 189);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(70, 22);
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "phút";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(8, 219);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(141, 18);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Thời gian thêm mỗi lượt";
            // 
            // cboTotalTimer
            // 
            this.cboTotalTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTotalTimer.FormattingEnabled = true;
            this.cboTotalTimer.Items.AddRange(new object[] {
            "5 ",
            "10",
            "15",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.cboTotalTimer.Location = new System.Drawing.Point(160, 159);
            this.cboTotalTimer.Name = "cboTotalTimer";
            this.cboTotalTimer.Size = new System.Drawing.Size(92, 24);
            this.cboTotalTimer.TabIndex = 8;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(8, 191);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 18);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Thời gian mỗi lượt";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(270, 158);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(70, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "phút";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(8, 161);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 18);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Thời gian ván đấu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Chess_Programming.Properties.Resources.Black_N;
            this.pictureBox2.Location = new System.Drawing.Point(188, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chess_Programming.Properties.Resources.White_N;
            this.pictureBox1.Location = new System.Drawing.Point(39, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // radWhite
            // 
            this.radWhite.AutoSize = true;
            this.radWhite.Location = new System.Drawing.Point(25, 116);
            this.radWhite.Margin = new System.Windows.Forms.Padding(5);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(94, 20);
            this.radWhite.TabIndex = 0;
            this.radWhite.TabStop = true;
            this.radWhite.Text = "Quân Trắng";
            this.radWhite.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(178, 116);
            this.radBlack.Margin = new System.Windows.Forms.Padding(5);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(83, 20);
            this.radBlack.TabIndex = 0;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Quân Đen";
            this.radBlack.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::Chess_Programming.Properties.Resources.Apply;
            this.btnStart.Location = new System.Drawing.Point(215, 326);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 36);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "&Đồng ý  ";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Chess_Programming.Properties.Resources.Pinion;
            this.button1.Location = new System.Drawing.Point(92, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Chỉnh sửa";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGameOptions
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 376);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grOptionGame);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGameOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy Chọn Trò Chơi - Cờ Vua 19DTHD4";
            this.Load += new System.EventHandler(this.FrmOptionGame_Load);
            this.grOptionGame.ResumeLayout(false);
            this.grOptionGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grOptionGame;
        private System.Windows.Forms.RadioButton radWhite;
        private System.Windows.Forms.RadioButton radBlack;
        private DevComponents .DotNetBar .ButtonX  btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevComponents .DotNetBar .ButtonX  button1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ComboBox cboExtraTimer;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.ComboBox cboMoveTimer;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.ComboBox cboUndo;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.ComboBox cboTotalTimer;
    }
}