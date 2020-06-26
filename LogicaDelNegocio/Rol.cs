using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDelNegocio
{
    public class Rol
    {
        public int IDRol { get; set; }
        public string RolUsuario { get; set; }

        public DataTable Listar()
        {
            DataTable retorno = new DataTable();
            Conexion Mycnn = new Conexion();
            retorno = Mycnn.Select("SpRolListar");

            return retorno;

        }
    }
}
