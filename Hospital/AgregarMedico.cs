﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class AgregarMedico : Form
    {
        public AgregarMedico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            Medico medico = new Medico(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text, textBox4.Text);
            
            medicos.Add(i) = medico;

            i++;
        }
    }
}
