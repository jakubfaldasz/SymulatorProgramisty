namespace JakubFałdaszLab1Zadanie
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxMainBlurred = new System.Windows.Forms.PictureBox();
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonExitGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonManual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainBlurred)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMainBlurred
            // 
            this.pictureBoxMainBlurred.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainBlurred.Image")));
            this.pictureBoxMainBlurred.ImageLocation = "";
            this.pictureBoxMainBlurred.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainBlurred.InitialImage")));
            this.pictureBoxMainBlurred.Location = new System.Drawing.Point(-24, -20);
            this.pictureBoxMainBlurred.Name = "pictureBoxMainBlurred";
            this.pictureBoxMainBlurred.Size = new System.Drawing.Size(850, 478);
            this.pictureBoxMainBlurred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMainBlurred.TabIndex = 0;
            this.pictureBoxMainBlurred.TabStop = false;
            this.pictureBoxMainBlurred.WaitOnLoad = true;
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMainTitle.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMainTitle.Location = new System.Drawing.Point(138, 84);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(525, 58);
            this.labelMainTitle.TabIndex = 1;
            this.labelMainTitle.Text = "Symulator Programisty";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartGame.Font = new System.Drawing.Font("Bahnschrift SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStartGame.Location = new System.Drawing.Point(306, 224);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(187, 52);
            this.buttonStartGame.TabIndex = 2;
            this.buttonStartGame.Text = "START";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonExitGame
            // 
            this.buttonExitGame.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonExitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExitGame.Font = new System.Drawing.Font("Bahnschrift SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExitGame.Location = new System.Drawing.Point(306, 340);
            this.buttonExitGame.Name = "buttonExitGame";
            this.buttonExitGame.Size = new System.Drawing.Size(187, 52);
            this.buttonExitGame.TabIndex = 4;
            this.buttonExitGame.Text = "WYJŚCIE";
            this.buttonExitGame.UseVisualStyleBackColor = false;
            this.buttonExitGame.Click += new System.EventHandler(this.buttonExitGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(601, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autor: Jakub Fałdasz";
            // 
            // buttonManual
            // 
            this.buttonManual.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonManual.Font = new System.Drawing.Font("Bahnschrift SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonManual.Location = new System.Drawing.Point(306, 282);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(187, 52);
            this.buttonManual.TabIndex = 6;
            this.buttonManual.Text = "JAK GRAĆ";
            this.buttonManual.UseVisualStyleBackColor = false;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonManual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExitGame);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelMainTitle);
            this.Controls.Add(this.pictureBoxMainBlurred);
            this.Name = "FormMain";
            this.Text = "Symulator Programisty";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainBlurred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainBlurred;
        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonExitGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonManual;
    }
}

