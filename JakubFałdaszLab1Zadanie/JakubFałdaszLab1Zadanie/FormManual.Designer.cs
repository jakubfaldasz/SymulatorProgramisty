namespace JakubFałdaszLab1Zadanie
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.labelManual2 = new System.Windows.Forms.Label();
            this.labelManual1 = new System.Windows.Forms.Label();
            this.labelManual3 = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.Image")));
            this.pictureBoxMain.ImageLocation = "";
            this.pictureBoxMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.InitialImage")));
            this.pictureBoxMain.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(802, 451);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMain.TabIndex = 2;
            this.pictureBoxMain.TabStop = false;
            // 
            // labelManual2
            // 
            this.labelManual2.AutoSize = true;
            this.labelManual2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelManual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelManual2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelManual2.Location = new System.Drawing.Point(12, 171);
            this.labelManual2.Name = "labelManual2";
            this.labelManual2.Size = new System.Drawing.Size(162, 120);
            this.labelManual2.TabIndex = 3;
            this.labelManual2.Text = "Odbierz telefon\r\npomarańczowym\r\nprzyciskiem kiedy \r\nzacznie migać \r\nczerwona lamp" +
    "ka.";
            // 
            // labelManual1
            // 
            this.labelManual1.AutoSize = true;
            this.labelManual1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelManual1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelManual1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelManual1.Location = new System.Drawing.Point(152, 105);
            this.labelManual1.Name = "labelManual1";
            this.labelManual1.Size = new System.Drawing.Size(206, 48);
            this.labelManual1.TabIndex = 4;
            this.labelManual1.Text = "Rozwiązuj zadania\r\nw wyznaczonym czasie";
            // 
            // labelManual3
            // 
            this.labelManual3.AutoSize = true;
            this.labelManual3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelManual3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelManual3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelManual3.Location = new System.Drawing.Point(559, 179);
            this.labelManual3.Name = "labelManual3";
            this.labelManual3.Size = new System.Drawing.Size(215, 96);
            this.labelManual3.TabIndex = 5;
            this.labelManual3.Text = "Uważaj na kończące \r\nsię zasoby! \r\nJedz hamburgery i pij\r\nkawę aby je uzupełniać." +
    "";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoBack.Font = new System.Drawing.Font("Bahnschrift SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(5, 7);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(187, 52);
            this.buttonGoBack.TabIndex = 6;
            this.buttonGoBack.Text = "MENU";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // FormManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelManual3);
            this.Controls.Add(this.labelManual1);
            this.Controls.Add(this.labelManual2);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "FormManual";
            this.Text = "Symulator Programisty";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label labelManual2;
        private System.Windows.Forms.Label labelManual1;
        private System.Windows.Forms.Label labelManual3;
        private System.Windows.Forms.Button buttonGoBack;
    }
}