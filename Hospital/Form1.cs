using System;
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
    
    public partial class Form1 : Form
    {
        private List<Medico> medicos;

        public List<Medico> Medicos { get => medicos; set => medicos = value; }

        public Form1(List<Medico> medicos)
        {
            this.medicos = Medicos;
            InitializeComponent();
            
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarMedico medicoNew = new AgregarMedico();
            medicoNew.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaMedicos listaMedicos = new ListaMedicos(medicos);
            MessageBox.Show(medicos(0).Nombre);
            
        }
    }
}
