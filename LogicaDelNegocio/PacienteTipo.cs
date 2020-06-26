using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDelNegocio
{
    public class PacienteTipo
    {
        public int IDPacienteTipo { get; set; }
        public string PacienteTipoStr { get; set; }

        public DataTable Listar()
        {
            DataTable retorno = new DataTable();
            Conexion Mycnn = new Conexion();
            retorno = Mycnn.Select("SpPacienteTipo");

            return retorno;

        }
    }
}
