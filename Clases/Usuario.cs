using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DocusContulmo.Clases;


namespace DocusContulmo.Clases
{
    class Usuario
    {
        private int IdTipoDeUsuario;
        private string RUN;
        private string Nombre1;
        private string Nombre2;
        private string Apellido1;
        private string Apellido2;
        private string Cargo;
        private string Email;
        private string Pass;
        private string UltimaVisita;
        private int Estado;
       
        Conexion MiConexion;
        DataTable TablaUsuario;
      


        public Usuario(){}

        public Usuario(string RUN, string Pass)
        {
            this.RUN = RUN;
            this.Pass = Pass;
        }

        public Boolean Validar(){
            
            MiConexion = new Conexion();
            MiConexion.IngresarQuery("ValidarUsuario",true);
            MiConexion.Comando.Parameters.Add("@RUN",SqlDbType.VarChar).Value = RUN;
            MiConexion.Comando.Parameters.Add("@PASS", SqlDbType.VarChar).Value = Pass;
            MiConexion.Comando.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Direction = ParameterDirection.Output;
            MiConexion.GenerarAdaptador();
          
           
            
           
            
            Console.Write("RUN: "+this.RUN+"\n");
            Console.Write("Pass: "+this.Pass+"\n");
            Console.Write("ID: " + MiConexion.Comando.Parameters["@ID_USUARIO"].Value + "\n");
           
            return true;
        }
        
    }
}
