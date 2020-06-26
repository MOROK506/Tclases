using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasProgra20202.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void gestionDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.ObjetosGlobales.MiFormDeGestionPersonas = new FrmPersonasGestion();
            Globales.ObjetosGlobales.MiFormDeGestionPersonas.Show();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
