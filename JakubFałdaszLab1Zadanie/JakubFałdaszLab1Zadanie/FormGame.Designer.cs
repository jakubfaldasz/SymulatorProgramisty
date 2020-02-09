namespace JakubFałdaszLab1Zadanie
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxEnergy = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoneCalls = new System.Windows.Forms.PictureBox();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.progressBarPhoneCalls = new System.Windows.Forms.ProgressBar();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.progressBarFood = new System.Windows.Forms.ProgressBar();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.progressBarTimeLeft = new System.Windows.Forms.ProgressBar();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.timerEndGame = new System.Windows.Forms.Timer(this.components);
            this.timerPhoneCall = new System.Windows.Forms.Timer(this.components);
            this.progressBarAnswerCall = new System.Windows.Forms.ProgressBar();
            this.timerEnergy = new System.Windows.Forms.Timer(this.components);
            this.buttonEnergy = new System.Windows.Forms.Button();
            this.labelGlowingPhone = new System.Windows.Forms.Label();
            this.progressBarEnergyEvent = new System.Windows.Forms.ProgressBar();
            this.labelScore = new System.Windows.Forms.Label();
            this.timerFood = new System.Windows.Forms.Timer(this.components);
            this.buttonFood = new System.Windows.Forms.Button();
            this.progressBarFoodEvent = new System.Windows.Forms.ProgressBar();
            this.labelEquals = new System.Windows.Forms.Label();
            this.buttonPhoneAnswerGlowing = new System.Windows.Forms.Button();
            this.labelRestart = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.Image")));
            this.pictureBoxMain.ImageLocation = "";
            this.pictureBoxMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.InitialImage")));
            this.pictureBoxMain.Location = new System.Drawing.Point(-24, -20);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(850, 478);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // pictureBoxEnergy
            // 
            this.pictureBoxEnergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxEnergy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnergy.BackgroundImage")));
            this.pictureBoxEnergy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEnergy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEnergy.Location = new System.Drawing.Point(597, 38);
            this.pictureBoxEnergy.Name = "pictureBoxEnergy";
            this.pictureBoxEnergy.Size = new System.Drawing.Size(38, 36);
            this.pictureBoxEnergy.TabIndex = 2;
            this.pictureBoxEnergy.TabStop = false;
            // 
            // pictureBoxPhoneCalls
            // 
            this.pictureBoxPhoneCalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxPhoneCalls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoneCalls.BackgroundImage")));
            this.pictureBoxPhoneCalls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhoneCalls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoneCalls.Location = new System.Drawing.Point(597, 80);
            this.pictureBoxPhoneCalls.Name = "pictureBoxPhoneCalls";
            this.pictureBoxPhoneCalls.Size = new System.Drawing.Size(38, 36);
            this.pictureBoxPhoneCalls.TabIndex = 3;
            this.pictureBoxPhoneCalls.TabStop = false;
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.BackColor = System.Drawing.Color.Black;
            this.progressBarEnergy.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBarEnergy.Location = new System.Drawing.Point(643, 51);
            this.progressBarEnergy.MarqueeAnimationSpeed = 50;
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBarEnergy.RightToLeftLayout = true;
            this.progressBarEnergy.Size = new System.Drawing.Size(145, 11);
            this.progressBarEnergy.Step = 5;
            this.progressBarEnergy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarEnergy.TabIndex = 4;
            this.progressBarEnergy.Value = 100;
            // 
            // progressBarPhoneCalls
            // 
            this.progressBarPhoneCalls.BackColor = System.Drawing.Color.Black;
            this.progressBarPhoneCalls.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBarPhoneCalls.Location = new System.Drawing.Point(643, 92);
            this.progressBarPhoneCalls.MarqueeAnimationSpeed = 50;
            this.progressBarPhoneCalls.Name = "progressBarPhoneCalls";
            this.progressBarPhoneCalls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBarPhoneCalls.RightToLeftLayout = true;
            this.progressBarPhoneCalls.Size = new System.Drawing.Size(145, 11);
            this.progressBarPhoneCalls.Step = 5;
            this.progressBarPhoneCalls.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPhoneCalls.TabIndex = 5;
            this.progressBarPhoneCalls.Value = 100;
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFood.BackgroundImage")));
            this.pictureBoxFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFood.Location = new System.Drawing.Point(597, 122);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(38, 36);
            this.pictureBoxFood.TabIndex = 6;
            this.pictureBoxFood.TabStop = false;
            // 
            // progressBarFood
            // 
            this.progressBarFood.BackColor = System.Drawing.Color.Black;
            this.progressBarFood.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBarFood.Location = new System.Drawing.Point(643, 134);
            this.progressBarFood.MarqueeAnimationSpeed = 50;
            this.progressBarFood.Name = "progressBarFood";
            this.progressBarFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBarFood.RightToLeftLayout = true;
            this.progressBarFood.Size = new System.Drawing.Size(145, 11);
            this.progressBarFood.Step = 5;
            this.progressBarFood.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarFood.TabIndex = 7;
            this.progressBarFood.Value = 100;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Black;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelTimer.Location = new System.Drawing.Point(355, 116);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(91, 42);
            this.labelTimer.TabIndex = 8;
            this.labelTimer.Text = "0:00";
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.BackColor = System.Drawing.Color.Black;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOperation.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelOperation.Location = new System.Drawing.Point(298, 189);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(88, 33);
            this.labelOperation.TabIndex = 10;
            this.labelOperation.Text = "2 + 2 ";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.Black;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxResult.ForeColor = System.Drawing.Color.LawnGreen;
            this.textBoxResult.Location = new System.Drawing.Point(441, 189);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(60, 33);
            this.textBoxResult.TabIndex = 11;
            this.textBoxResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxResult_KeyUp);
            // 
            // progressBarTimeLeft
            // 
            this.progressBarTimeLeft.Location = new System.Drawing.Point(301, 227);
            this.progressBarTimeLeft.MarqueeAnimationSpeed = 10;
            this.progressBarTimeLeft.Name = "progressBarTimeLeft";
            this.progressBarTimeLeft.Size = new System.Drawing.Size(194, 10);
            this.progressBarTimeLeft.Step = 1;
            this.progressBarTimeLeft.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTimeLeft.TabIndex = 12;
            this.progressBarTimeLeft.Value = 100;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevel.ForeColor = System.Drawing.Color.Yellow;
            this.labelLevel.Location = new System.Drawing.Point(341, 34);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(119, 29);
            this.labelLevel.TabIndex = 13;
            this.labelLevel.Text = "Poziom: 1";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Black;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameOver.ForeColor = System.Drawing.Color.DarkRed;
            this.labelGameOver.Location = new System.Drawing.Point(155, 169);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(489, 85);
            this.labelGameOver.TabIndex = 14;
            this.labelGameOver.Text = "GAME OVER";
            this.labelGameOver.Visible = false;
            // 
            // timerEndGame
            // 
            this.timerEndGame.Interval = 1000;
            this.timerEndGame.Tick += new System.EventHandler(this.timerEndGame_Tick);
            // 
            // timerPhoneCall
            // 
            this.timerPhoneCall.Enabled = true;
            this.timerPhoneCall.Interval = 500;
            this.timerPhoneCall.Tick += new System.EventHandler(this.timerPhoneCall_Tick);
            // 
            // progressBarAnswerCall
            // 
            this.progressBarAnswerCall.Location = new System.Drawing.Point(87, 390);
            this.progressBarAnswerCall.Name = "progressBarAnswerCall";
            this.progressBarAnswerCall.Size = new System.Drawing.Size(83, 10);
            this.progressBarAnswerCall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarAnswerCall.TabIndex = 19;
            this.progressBarAnswerCall.Value = 100;
            this.progressBarAnswerCall.Visible = false;
            // 
            // timerEnergy
            // 
            this.timerEnergy.Enabled = true;
            this.timerEnergy.Interval = 500;
            this.timerEnergy.Tick += new System.EventHandler(this.timerEnergy_Tick);
            // 
            // buttonEnergy
            // 
            this.buttonEnergy.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnergy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEnergy.BackgroundImage")));
            this.buttonEnergy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEnergy.FlatAppearance.BorderSize = 0;
            this.buttonEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnergy.Location = new System.Drawing.Point(602, 322);
            this.buttonEnergy.Name = "buttonEnergy";
            this.buttonEnergy.Size = new System.Drawing.Size(67, 91);
            this.buttonEnergy.TabIndex = 20;
            this.buttonEnergy.UseVisualStyleBackColor = false;
            this.buttonEnergy.Visible = false;
            this.buttonEnergy.Click += new System.EventHandler(this.buttonEnergy_Click);
            // 
            // labelGlowingPhone
            // 
            this.labelGlowingPhone.AutoSize = true;
            this.labelGlowingPhone.Image = ((System.Drawing.Image)(resources.GetObject("labelGlowingPhone.Image")));
            this.labelGlowingPhone.Location = new System.Drawing.Point(149, 299);
            this.labelGlowingPhone.Name = "labelGlowingPhone";
            this.labelGlowingPhone.Size = new System.Drawing.Size(16, 13);
            this.labelGlowingPhone.TabIndex = 21;
            this.labelGlowingPhone.Text = "   ";
            this.labelGlowingPhone.Visible = false;
            // 
            // progressBarEnergyEvent
            // 
            this.progressBarEnergyEvent.Location = new System.Drawing.Point(594, 418);
            this.progressBarEnergyEvent.Name = "progressBarEnergyEvent";
            this.progressBarEnergyEvent.Size = new System.Drawing.Size(83, 10);
            this.progressBarEnergyEvent.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarEnergyEvent.TabIndex = 22;
            this.progressBarEnergyEvent.Value = 100;
            this.progressBarEnergyEvent.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.ForeColor = System.Drawing.Color.Aqua;
            this.labelScore.Location = new System.Drawing.Point(12, 62);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(118, 31);
            this.labelScore.TabIndex = 23;
            this.labelScore.Text = "Wynik: 0";
            // 
            // timerFood
            // 
            this.timerFood.Interval = 500;
            this.timerFood.Tick += new System.EventHandler(this.timerFood_Tick);
            // 
            // buttonFood
            // 
            this.buttonFood.AutoSize = true;
            this.buttonFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFood.BackgroundImage")));
            this.buttonFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFood.FlatAppearance.BorderSize = 0;
            this.buttonFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFood.Location = new System.Drawing.Point(709, 205);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(81, 79);
            this.buttonFood.TabIndex = 24;
            this.buttonFood.UseVisualStyleBackColor = false;
            this.buttonFood.Visible = false;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // progressBarFoodEvent
            // 
            this.progressBarFoodEvent.Location = new System.Drawing.Point(707, 279);
            this.progressBarFoodEvent.Name = "progressBarFoodEvent";
            this.progressBarFoodEvent.Size = new System.Drawing.Size(81, 10);
            this.progressBarFoodEvent.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarFoodEvent.TabIndex = 25;
            this.progressBarFoodEvent.Value = 100;
            this.progressBarFoodEvent.Visible = false;
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.BackColor = System.Drawing.Color.Black;
            this.labelEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEquals.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelEquals.Location = new System.Drawing.Point(410, 189);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(32, 33);
            this.labelEquals.TabIndex = 26;
            this.labelEquals.Text = "=";
            // 
            // buttonPhoneAnswerGlowing
            // 
            this.buttonPhoneAnswerGlowing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPhoneAnswerGlowing.BackgroundImage")));
            this.buttonPhoneAnswerGlowing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPhoneAnswerGlowing.FlatAppearance.BorderSize = 0;
            this.buttonPhoneAnswerGlowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhoneAnswerGlowing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPhoneAnswerGlowing.Location = new System.Drawing.Point(116, 368);
            this.buttonPhoneAnswerGlowing.Name = "buttonPhoneAnswerGlowing";
            this.buttonPhoneAnswerGlowing.Size = new System.Drawing.Size(22, 13);
            this.buttonPhoneAnswerGlowing.TabIndex = 18;
            this.buttonPhoneAnswerGlowing.Text = "button2";
            this.buttonPhoneAnswerGlowing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPhoneAnswerGlowing.UseVisualStyleBackColor = true;
            this.buttonPhoneAnswerGlowing.Visible = false;
            this.buttonPhoneAnswerGlowing.Click += new System.EventHandler(this.buttonPhoneAnswerGlowing_Click);
            // 
            // labelRestart
            // 
            this.labelRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRestart.ForeColor = System.Drawing.Color.DarkRed;
            this.labelRestart.Location = new System.Drawing.Point(155, 254);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRestart.Size = new System.Drawing.Size(489, 23);
            this.labelRestart.TabIndex = 27;
            this.labelRestart.Text = "NACIŚNIJ ENTER ABY ZAGRAĆ PONOWNIE";
            this.labelRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRestart.Visible = false;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGoBack.Location = new System.Drawing.Point(12, 12);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(83, 36);
            this.buttonGoBack.TabIndex = 28;
            this.buttonGoBack.Text = "MENU";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.labelEquals);
            this.Controls.Add(this.progressBarFoodEvent);
            this.Controls.Add(this.buttonFood);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.progressBarEnergyEvent);
            this.Controls.Add(this.labelGlowingPhone);
            this.Controls.Add(this.buttonEnergy);
            this.Controls.Add(this.progressBarAnswerCall);
            this.Controls.Add(this.buttonPhoneAnswerGlowing);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.progressBarTimeLeft);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.progressBarFood);
            this.Controls.Add(this.pictureBoxFood);
            this.Controls.Add(this.progressBarPhoneCalls);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.pictureBoxPhoneCalls);
            this.Controls.Add(this.pictureBoxEnergy);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "FormGame";
            this.Text = "Symulator Programisty";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.PictureBox pictureBoxEnergy;
        private System.Windows.Forms.PictureBox pictureBoxPhoneCalls;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.ProgressBar progressBarPhoneCalls;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.ProgressBar progressBarFood;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ProgressBar progressBarTimeLeft;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Timer timerEndGame;
        private System.Windows.Forms.Timer timerPhoneCall;
        private System.Windows.Forms.ProgressBar progressBarAnswerCall;
        private System.Windows.Forms.Timer timerEnergy;
        private System.Windows.Forms.Button buttonEnergy;
        private System.Windows.Forms.Label labelGlowingPhone;
        private System.Windows.Forms.ProgressBar progressBarEnergyEvent;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerFood;
        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.ProgressBar progressBarFoodEvent;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.Button buttonPhoneAnswerGlowing;
        private System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.Button buttonGoBack;
    }
}