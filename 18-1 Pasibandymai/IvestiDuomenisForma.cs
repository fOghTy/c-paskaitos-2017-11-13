﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_1_Pasibandymai
{
    public partial class IvestiDuomenisForma : Form
    {
        public string Vardas { get; private set; }
        public int Amzius { get; private set; }

        public IvestiDuomenisForma()
        {
            InitializeComponent();
        }

        private void IvestiDuomenisForma_Load(object sender, EventArgs e)
        {

        }

        private void buttonGerai_Click(object sender, EventArgs e)
        {
            Vardas = textBoxVardas.Text;
            Amzius = Convert.ToInt32(textBoxAmzius.Text);
        }
    }
}
