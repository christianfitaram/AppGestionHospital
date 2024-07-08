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
    public partial class ListaMedicos : Form
    {
        private List<Medico> medicos;

        public List<Medico> Medicos { get => medicos; set => medicos = value; }
        public ListaMedicos(List<Medico> medicos)
        {
            this.medicos = Medicos;
            InitializeComponent();
            
        }
    }
}
