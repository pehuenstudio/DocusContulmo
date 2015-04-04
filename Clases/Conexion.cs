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
        //private DataTable _tabla;
        private string _query;

        public Conexion() { }
        
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
        public string Query
        {
            get { return _query; }
            set { _query = value; }
        }

        public void IngresarComando(string query)
        {
            _comando = new SqlCommand(query, _miConexion);
        }
        public void GenerarAdaptador()
        {
            _adaptador = new SqlDataAdapter(_comando);
        }
       /* public DataTable GenerarTabla(string NombreTabla)
        {
            _tabla = new DataTable(NombreTabla);
            _tabla.Columns.Add("");
            return _tabla;
        }*/
    }
}
