using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasProgra20202.Globales
{
    public static class ObjetosGlobales
    {
        //esta clase contiene objetos que se puee usar en cualquier parte del sistema 
        //al definirla como static se crea una instancia automatica al iniciar la aplicacion 

        public static Formularios.FrmPrincipal MiFormPrincipal = new Formularios.FrmPrincipal();
        public static Formularios.FrmPersonasGestion MiFormDeGestionPersonas = new Formularios.FrmPersonasGestion();
    }
}
