using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubFałdaszLab1Zadanie
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Konstruktor okna głównego
        /// </summary>
        public FormMain()
        {
            //Zablokowanie zmiany rozmiaru okna
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        /// <summary>
        /// Zainicjowanie okna z grą i schowanie okna głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame();
            formGame.Show();
            formGame.Location = this.Location;
            this.Hide();
        }
        
        /// <summary>
        /// Wyłączenie programu po zamknięciu okna głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Przejście do samouczka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonManual_Click(object sender, EventArgs e)
        {
            FormManual formManual = new FormManual();
            formManual.Show();
            formManual.Location = this.Location;
            this.Hide();
        }
    }
}
