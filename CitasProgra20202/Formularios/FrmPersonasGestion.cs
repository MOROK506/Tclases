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
    public partial class FrmPersonasGestion : Form
    {       //ATRIBUTOS LOCALES
        // este objeto permite manipular los datos y vincular los datos del form y luego
        //pasarlos a el base de datos por medio de la funcion
        private LogicaDelNegocio.Persona MiPersonaLocal = new LogicaDelNegocio.Persona();
        private DataTable DtListaPersonas = new DataTable();

        //constructor del form
        public FrmPersonasGestion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // DvgLista.ClearSelection
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersonasGestion_Load(object sender, EventArgs e)
        {

            MdiParent = Globales.ObjetosGlobales.MiFormPrincipal;
            // SE HACE UN LLAMADO A LA FUNCION LISTAR ACTIVOS DE LA CLASE PERSONA 
            // para presentarlo en el data gridview
            // ENCAPSULAR BLOQUES RELATIVOS DE CODIGO SIEMPREEEE

            LlenarListaPersonas();
            LlenarComboPersonaTipo();
            LlenarComboRol();
            LlenarComboPacienteTipo();
        }

        private void LlenarComboPacienteTipo()
        {
            DataTable L = new DataTable();
            LogicaDelNegocio.PacienteTipo objPacienteTipo = new LogicaDelNegocio.PacienteTipo();
            L = objPacienteTipo.Listar();
            CboxPasienteTipo.ValueMember = "pt";
            CboxPasienteTipo.DisplayMember = "p";

            CboxPasienteTipo.DataSource = L;
            CboxPasienteTipo.SelectedIndex = -1;
        }

        private void LlenarComboRol()
        {
            DataTable R = new DataTable();
            LogicaDelNegocio.Rol objRol = new LogicaDelNegocio.Rol();
            R = objRol.Listar();
            CboxRol.ValueMember = "id";
            CboxRol.DisplayMember = "r";
            CboxRol.DataSource = R;
            CboxRol.SelectedIndex = -1;
            
        }
         
        private void LlenarComboPersonaTipo()
        {
            DataTable L = new DataTable();
            LogicaDelNegocio.PersonaTipo objPersonaTipo = new LogicaDelNegocio.PersonaTipo();
            L = objPersonaTipo.Listar();
            CboxPersonaTipo.ValueMember = "id";
            CboxPersonaTipo.DisplayMember = "d";

            CboxPersonaTipo.DataSource = L;
            CboxPersonaTipo.SelectedIndex = -1;
        }
        private void LlenarListaPersonas()
        {

            DtListaPersonas = new DataTable();

            // se carga en un datatable local el resultado de la funcion listar activos 

            DtListaPersonas = MiPersonaLocal.ListarActivos();

            // se muestra en el data grid los datos contenidos en el datatable 

            DgvLista.DataSource = DtListaPersonas;
            
        
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
