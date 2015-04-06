using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DocusContulmo.Clases
{
    class Conexion
    {
        private static SqlConnection _miConexion = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data\DDBB.mdf;Integrated Security=True");
        private SqlCommand _comando;
        private SqlDataAdapter _adaptador;
        private DataTable _tabla;
        
        public Conexion() {
            _miConexion.Open();
        }
        
        //GETTERS Y SETTERS
        public SqlCommand Comando
        {
            get { return _comando; }
            set { 
                    _comando = value; 
                }
        }
        public SqlDataAdapter Apaptador
        {
            get { return _adaptador; }
            set { _adaptador = value; }
        }
        public DataTable Tabla
        {
            get { return _tabla; }
            set { _tabla = value; }
        }

        public void IngresarQuery(string Query, Boolean EsProcedimiento)
        {
            _comando = new SqlCommand(Query, _miConexion);
            if (EsProcedimiento)
            {
                _comando.CommandType = CommandType.StoredProcedure;
            }
        }
        public void GenerarAdaptador()
        {
            _adaptador = new SqlDataAdapter(_comando);
        }
        public DataTable GenerarTabla(string NombreTabla)
        {
            _tabla = new DataTable(NombreTabla);
            int contador = _adaptador.Fill(_tabla);
            Console.Write("\nFILAS AFECTADAS = "+contador+"\n");
            return _tabla;
        }

        public void Cerrar() {
            _miConexion.Close();
        }
    }
}
