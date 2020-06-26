using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDelNegocio
{
    public class Especialidad
    {
        public int IDEspecialidad { get; set; }
        public string NombreEspecialidad { get; set; }
        public string Comentario { get; set; }


        public DataTable Listar()
        {
           
            DataTable retorno = new DataTable();

            return retorno;

        }

        public Boolean Agregar()
        {
            Boolean retorno = new Boolean();

            return retorno;

        }

        public Boolean Modificar()
        {
            Boolean retorno = new Boolean();

            return retorno;

        }

        public Boolean Eliminar()
        {
            Boolean retorno = new Boolean();

            return retorno;

        }

        public Boolean ConsultarPorNombre()
        {
            Boolean retorno = new Boolean();

            return retorno;

        }
    }
}
