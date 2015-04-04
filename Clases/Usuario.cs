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
       
      


        public Usuario(){}

        public Usuario(string RUN, string Pass)
        {
            this.RUN = RUN;
            this.Pass = Pass;
        }

        public Boolean ValidarUsuario(){
            Conexion MiConexion = new Conexion();
            //MiConexion.Query = "select ID_USUARIO from USUARIOS where RUN = '16689083-7' and PASS = 'GALATEA';";
            MiConexion.IngresarComando("select ID_USUARIO from USUARIOS where RUN = '"+this.RUN+"' and PASS = '"+this.Pass+"';");
            MiConexion.GenerarAdaptador();
            DataTable TablaUsuario = new DataTable("Usuario");
            MiConexion.Apaptador.Fill(TablaUsuario);
           
            
            Console.Write("RUN: "+this.RUN+"\n");
            Console.Write("Pass: "+this.Pass);
            return true;
        }
        
    }
}
