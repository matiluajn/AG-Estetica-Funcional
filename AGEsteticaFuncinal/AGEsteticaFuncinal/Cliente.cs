using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGEsteticaFuncinal
{
    class Cliente
    {
        public Int64 dni { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public DateTime fechaNacimiento { set; get; }
        public Int64 celular { set; get; }
        public Int64 telefono { set; get; }
        public string calle { set; get; }
        public int numero { set; get; }
        public string barrio { set; get; }
        public int cp { set; get; }
        public string email { set; get; }
        public string derivacionMedica { set; get; }
        public string diagnostico { set; get; }
        public string medicacion { set; get; }
        public string lesion { set; get; }
        public DateTime fechaAlta { set; get; }

    }
}
