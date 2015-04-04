using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            
            return true;
        }
        
    }
}
