using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class Parametros_ASIG
    {
        private string SP_asig;
        private object Val_asig;
        private SqlDbType tipodato_asig;
        private ParameterDirection direccion_asig;
        private int asig_tamaño;

        public string SP_asig1 { get => SP_asig; set => SP_asig = value; }
        public object Val_asig1 { get => Val_asig; set => Val_asig = value; }
        public SqlDbType Tipodato_asig { get => tipodato_asig; set => tipodato_asig = value; }
        public ParameterDirection Direccion_asig { get => direccion_asig; set => direccion_asig = value; }
        public int Asig_tamaño { get => asig_tamaño; set => asig_tamaño = value; }

        public Parametros_ASIG(string objnombreasig, object objValorasgi)
        {
            SP_asig = objnombreasig;
            Val_asig = objValorasgi;
            direccion_asig = ParameterDirection.Input;
        }
        public Parametros_ASIG(string objnombreasig, object objValorasgig, SqlDbType objtipodatoasgi, ParameterDirection objDireccionasgi, int objTamañoasig)
        {
            SP_asig = objnombreasig;
            Val_asig = objValorasgig;
            tipodato_asig = objtipodatoasgi;
            direccion_asig = objDireccionasgi;
            asig_tamaño = objTamañoasig;
        }
    }
   
}
