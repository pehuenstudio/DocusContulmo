using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DocusContulmo.Clases;
using System.Windows.Forms;


namespace DocusContulmo.Clases
{
    class Usuario
    {
        private int  _IdTipoDeUsuario;
        private RUN _RUN;
        private string _Nombre1;
        private string _Nombre2;
        private string _Apellido1;
        private string _Apellido2;
        private string _Cargo;
        private string _Email;
        private string _Pass;
        private string _UltimaVisita;
        private int _Estado;
       
        Conexion MiConexion;
        DataTable TablaUsuario;
      


        public Usuario(){}

        public Usuario(string RUN, string Pass)
        {
            _RUN = new RUN(RUN);
            _Pass = Pass;
        }

        public Boolean validarRUN() {
            if (!_RUN.ValidacionGeneral()) 
            {
                return false;
            }
            if (!_RUN.ValidarDigitoVerificador())
            {
                return false;
            }
        
            return true;
        }

        public Boolean Validar(){
            if (!validarRUN())
            {
                MessageBox.Show("RUN no valido!");
            }
           /* MiConexion = new Conexion();
            MiConexion.IngresarQuery("ValidarUsuario",true);
            MiConexion.Comando.Parameters.Add("@RUN",SqlDbType.VarChar).Value = _RUN;
            MiConexion.Comando.Parameters.Add("@PASS", SqlDbType.VarChar).Value = _Pass;
            MiConexion.Comando.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Direction = ParameterDirection.Output;
            MiConexion.GenerarAdaptador();
          
                  
            
            Console.Write("RUN: "+this._RUN+"\n");
            Console.Write("Pass: "+this._Pass+"\n");
            Console.Write("ID: " + MiConexion.Comando.Parameters["@ID_USUARIO"].Value + "\n");

            MiConexion.Cerrar();*/
            return true;
        }
        
    }
}
