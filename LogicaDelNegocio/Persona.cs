using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDelNegocio
{
    public class Persona
    {
        //esta clase al ser compuesta la dividimo en tres partes
        //1-atributos simples
        //2-atributos compuestos
        //3-metodos y funciones

        //1.
        public int IDPersona { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Boolean Activo { get; set; }
        public string Contrasennia { get; set; }

        //2.

        public PersonaTipo TipoPersona { get; set; }
        public Rol TipoRol { get; set; }
        public PacienteTipo TipoPaciente { get; set; }

        public List<Especialidad> ListaDeEspecialidades { get; set; }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            // primera llamada  a sp en base de datos
            // 1 crear una instancia de la clase conexion
            Conexion Micnn = new Conexion();

            R = Micnn.Select("SpPersonasListar");

            
            return R;
        }


    }
}
