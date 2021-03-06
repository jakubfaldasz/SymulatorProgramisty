﻿using System;
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
    public partial class FormManual : Form
    {
        /// <summary>
        /// Konstruktor klasy FormManual
        /// </summary>
        public FormManual()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk powrotu do menu głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            formMain.Location = this.Location;
            this.Hide();
        }
    }
}
