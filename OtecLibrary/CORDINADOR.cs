using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class CORDINADOR
    {
        private string nom_cordinador;
        private string cod_cordinador;
        private int telefono;

        ConectionBD datoconex = new ConectionBD();

        public string Nom_cordinador { get => nom_cordinador; set => nom_cordinador = value; }
        public string Cod_cordinador { get => cod_cordinador; set => cod_cordinador = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public CORDINADOR()
        {

        }

        public CORDINADOR(string nom_cordinador, string cod_cordinador, int telefono)
        {
            this.Cod_cordinador = cod_cordinador;
            this.Nom_cordinador = nom_cordinador;
            this.Telefono = telefono;
        }

        public DataSet listadocordinador()
        {
            return datoconex.listar("SELECT * FROM ro_bf_CORDINADOR");
        }

        public DataSet listadoEmpleado(string cod_cordinador)
        {
            return datoconex.listar("SELECT * FROM ro_bf_CORDINADOR WHERE cod_asignatura = '" + cod_cordinador + "'");
        }

        public int guardardato(CORDINADOR cord)
        {
            return datoconex.GuardarDatos("Insert into ro_bf_CORDINADOR(cod_cordinador, nom_cordinador,telefono) values('" + cord.Cod_cordinador + "','" + cord.Nom_cordinador + "','" + cord.Telefono + "')");
        }

        public int guardar(CORDINADOR cord)
        {
            return datoconex.GuardarDatos("Insert into  ro_bf_CORDINADOR(cod_cordinador, nom_cordinador,telefono) values('" + cord.Cod_cordinador + "','" + cord.Nom_cordinador + "','" + cord.Telefono + "')");
        }
        public int guardarcord()
        {
            return datoconex.GuardarDatos("Insert into  ro_bf_CORDINADOR(cod_cordinador, nom_cordinador,telefono) values('" + this.cod_cordinador + "','" + this.nom_cordinador + "','" + this.telefono+ "')");
        }
        public int eliminarcord()
        {
            return datoconex.GuardarDatos("DELETE FROM ro_bf_CORDINADOR WHERE cod_cordinador = '" + this.cod_cordinador + "'");
        }
        public int modificarcord(CORDINADOR cord)
        {
            return datoconex.GuardarDatos("UPDATE ro_bf_CORDINADOR SET  cod_cordinador = '" + cord.cod_cordinador + "', nom_cordinador'" + cord.nom_cordinador + "', telefono ='" + cord.telefono + "'");
        }

    }
}
