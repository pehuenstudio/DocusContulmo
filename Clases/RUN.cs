using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocusContulmo.Clases
{
    class RUN
    {
        private string _Numero;
        private string _DigitoVerificador;

        //GETTERS Y SETTERS
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }
        public string DigitoVerificador
        {
            get { return _DigitoVerificador; }
            set { _DigitoVerificador = value; }
        }

        public RUN() { }
        public RUN(string RUN) {
            RUN = RUN.Replace(".", "").Replace("-", "").ToUpper();
            if (RUN.Length == 0)
            {
                RUN = "NULL";
               
            }

            _Numero = RUN.Substring(0, RUN.Length - 1);
            _DigitoVerificador = RUN.Substring(RUN.Length - 1);

        }
        public RUN(string Numero, string DigitoVerificador) {
            _Numero = Numero;
            _DigitoVerificador = DigitoVerificador;
        }

        public Boolean ValidacionGeneral() {
            int n;
            //SI TIENE LA LONGITUD INCORRECTA
            if (_Numero.Length < 7 || _Numero.Length > 8)
            {
                Console.Write("\nERROR RUN = No tiene la longitud correcta = " + _Numero.Length + "\n");
                return false;
            }

            //SI TIENE LETRAS ANTES DEL DV
            if (!int.TryParse(_Numero, out n)) {
                Console.Write("\nERROR RUN = contiene letras antes del DV = " + _Numero + "\n");
                return false;
            }

            //SI EL DIGITO VERIFICADOR ES INCORRECTO
            if (!int.TryParse(_DigitoVerificador, out n) && !_DigitoVerificador.Equals("K"))
            {
                Console.Write("\nERROR RUN = DV es no es numero ni es K = " + _DigitoVerificador + "\n");
                return false;
            }
                        
            return true;
        }

        public Boolean ValidarDigitoVerificador(){
            int [] Serie = {2,3,4,5,6,7};
            int[] Digitos = new int[_Numero.Length];
            int[] Productos = new int[_Numero.Length];
            int Acumulador = 0;
            int j = 0;
            for (int i = _Numero.Length-1; i >=0 ; i--) 
            {
                Digitos[i] = Convert.ToInt32(_Numero.Substring(i,1));
                Productos[i] = Digitos[i] * Serie[j];
                Acumulador = Acumulador + Productos[i];
                j++;
                if (j > 5) {
                    j = 0;
                }
            }
            int Resto = Acumulador % 11;

            if (_DigitoVerificador.Equals("0")) 
            {
                _DigitoVerificador = "11";
            }
            if (_DigitoVerificador.Equals("K"))
            { 
                _DigitoVerificador = "10"; 
            }

            if ((11 - Resto) != Convert.ToInt32(_DigitoVerificador)) {
                Console.Write("\nNo es un rut Valido\n");
                return false;
            }
            Console.Write("\nEs un rut Valido\n");
            return true;
        }
        
    }
}
