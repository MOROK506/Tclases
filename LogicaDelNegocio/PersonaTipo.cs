using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDelNegocio
{
    public class PersonaTipo
    {
        //primero escribimos el codigo para los atributos

        public int IDPersonaTipo { get; set; }
        public string Tipo { get; set; }


        //Luego se escriben las funciones

        public DataTable Listar()
        {
            DataTable retorno = new DataTable();
            Conexion Mycnn = new Conexion();
            retorno = Mycnn.Select("SPpersonaTipoListar");


            return retorno;

        }
    }
}
