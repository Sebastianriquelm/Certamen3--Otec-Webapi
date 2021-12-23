using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class ASIGNATURA
    {
        private string cod_asignatura;
        private string nom_asignatura;

        ConectionBD datoconex = new ConectionBD();

        public string Cod_asignatura { get => cod_asignatura; set => cod_asignatura = value; }
        public string Nom_asignatura { get => nom_asignatura; set => nom_asignatura = value; }

        public ASIGNATURA()
        {

        }

        public ASIGNATURA(string cod_asignatura, string nom_asignatura)
        {
            this.cod_asignatura = cod_asignatura;
            this.nom_asignatura = nom_asignatura;
        }

        public DataSet listadocordinador()
        {
            return datoconex.listar("SELECT * FROM ro_bf_ASIGNATURA");
        }

        public DataSet listadocordinador(string cod_asignatura)
        {
            List<Parametros_ASIG> lst = new List<Parametros_ASIG>();
            lst.Add(new Parametros_ASIG("@COD_ASIGNATURA", cod_asignatura));
            return datoconex.listado("SP_BUSCASIG", lst);

        }

        public int guardardato(ASIGNATURA asig)
        {
            return datoconex.GuardarDatos("Insert into ro_bf_ASIGNATURA(cod_asignatura,nom_asignatura) values('" + asig.Cod_asignatura + "','" + asig.Nom_asignatura +  "')");
        }

        public int guardar(ASIGNATURA asig)
        {
            return datoconex.GuardarDatos("Insert into  ro_bf_ASIGNATURA(cod_asignatura,nom_asignatura) values('" + asig.Cod_asignatura + "','" + asig.Nom_asignatura + "','" + "')");
        }
        public int guardarasi()
        {
            return datoconex.GuardarDatos("Insert into  ro_bf_ASIGNATURA(cod_asignatura,nom_asignatura)values('" + this.cod_asignatura + "','" + this.nom_asignatura  +"')");
        }
        public int eliminarasi()
        {
            return datoconex.GuardarDatos("DELETE FROM ro_bf_ASIGNATURA WHERE cod_cordinador = '" + this.cod_asignatura + "'");
        }
        public int modificarasi(ASIGNATURA asig)
        {
            return datoconex.GuardarDatos("UPDATE ro_bf_ASIGNATURA SET  cod_cordinador = '" + asig.cod_asignatura + "', nom_asignatura'" + asig.nom_asignatura +  "'");
        }

    }

    }


