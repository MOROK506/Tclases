using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaDelNegocio
{
   public  class Conexion
    {

        //atributos de la clase 
        private string CadenaDeConexion { get; set; }
        public List<SqlParameter> ListadoDeParametros = new List<SqlParameter>();

       //OPERACIONES DE LA CLASE 
        public Conexion()
            //este es el constructor default de la calse
        {
            /*cada vez que se hace una instancia de la calse 
            // se debe de llenar info en el atrib de cadena de conexion
            //esta informacion estara contenida dentro del archivo  app.config*/
            this.CadenaDeConexion = ConfigurationManager.ConnectionStrings["CnnStrCitas"].ToString();
        
        }

        //las operaciones que siguen son para efectuar los DML contra la base de datos

        public DataTable Select(string NombreProcedimientoAlmacenado)
        {
            DataTable R = new DataTable();
            //permite definir una variable dentro del parentisis conexion con la base de datos
            using (SqlConnection MiConexion = new SqlConnection(CadenaDeConexion))
                //HACE UN VINCULO CON LA BASE DE DATOS 
            {
                SqlCommand MiComando = new SqlCommand(NombreProcedimientoAlmacenado, MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;
                //Existe la posibilidad de que un sp lleve o no una lista de parametros.
                //el siguiente codigo evalua si el atributo de la lista de params tiene o no
                //valores y si los tienen hace un recorrido con un bucle foreach
                if (ListadoDeParametros != null && ListadoDeParametros.Count>0)
                {
                    foreach (SqlParameter item in ListadoDeParametros)
                    {
                        MiComando.Parameters.Add(item);
                    }
                }
                // una vez que definimos el command y los posibles parametros 
                //se procede a efectuar la operacion contra la bd

                //SqlDataAdapter es un comunicador con una base de datos
                SqlDataAdapter MiPuente = new SqlDataAdapter(MiComando);
                // fill  carga al DataTable el resultado de la consulta SELECT(que esta dentro del SP(sp es procedimiento almacenado))
                MiPuente.Fill(R);
            }
            //cuando la variable sale se destruye el vinculo
            return R;
        }
        // la siguiente funcion  funciona para los DML insert update yDelete.
        public int HacerDML(string NombreProcedimientoAlmacenado)
        {

            int R = 0;

            using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))
            {

                SqlCommand MyCommand = new SqlCommand(NombreProcedimientoAlmacenado, MyCnn);
                MyCommand.CommandType = CommandType.StoredProcedure;
                if (ListadoDeParametros != null && ListadoDeParametros.Count> 0)

                {
                    foreach (SqlParameter  item in ListadoDeParametros)
                    {
                        MyCommand.Parameters.Add(item);
                    }

                }

                MyCnn.Open();

                R = MyCommand.ExecuteNonQuery();
                //con esta tecnica se hace apertura de conexion a la base de datos
                //y luego el executeNonQuery() devuelve la cantidad de registros afectados 
                //por la operacion DML (INSERT UPDATE DELETE)


            }


            return R;
        }

    }
}
