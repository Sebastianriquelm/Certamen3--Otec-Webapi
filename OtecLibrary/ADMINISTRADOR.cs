using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtecLibrary
{
    public class ADMINISTRADOR
    {

        private string cod_admin;
        private string nombre_admin;
        private string correo;
        private string telefono;

        ConectionBD datoconex = new ConectionBD();

        public string Cod_admin { get => cod_admin; set => cod_admin = value; }
        public string Nombre_admin { get => nombre_admin; set => nombre_admin = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        

        public ADMINISTRADOR()
        {

        }

        public ADMINISTRADOR(string cod_admin, string nombre_admin, string correo, string telefono)
        {
            this.cod_admin = cod_admin;
            this.nombre_admin = nombre_admin;
            this.correo = correo;
            this.telefono = telefono;
        }
        public DataSet listadoadministrador()
        {
            return datoconex.listar("SELECT * FROM ro_bf_ADMINISTRADOR");
        }

        public DataSet listadoadministrador(string cod_admin)
        {
            List<Parametros_ASIG> lst = new List<Parametros_ASIG>();
            lst.Add(new Parametros_ASIG("@COD_ADMIN", cod_admin));
            return datoconex.listado("SP_Searchadmin", lst);

        }

        public int guardardato(ADMINISTRADOR admin)
        {
            return datoconex.GuardarDatos("Insert into ro_bf_ADMINISTRADOR(cod_admin,nombre_admin,correo,telefono) values('" + admin.Cod_admin + "','" + admin.Nombre_admin + "','" + admin.Correo + "','" + admin.Telefono + "')");
        }

        public int guardar(ADMINISTRADOR admin)
        {
            return datoconex.GuardarDatos("Insert into  ro_bf_ADMINISTRADOR(cod_admin,nombre_admin,correo,telefono) values('" + admin.Cod_admin + "','" + admin.Nombre_admin + "','" + admin.Correo + "','" + admin.Telefono + "')");
        }
        public int guardaradmi()
        {
            return datoconex.GuardarDatos("Insert into  ro_bf_ADMINISTRADOR(cod_admin,nombre_admin,correo,telefono) values('" + this.cod_admin + "','" + this.nombre_admin + "','" + this.correo + "','" + this.telefono + "')");
        }
        public int eliminaradmi()
        {
            return datoconex.GuardarDatos("DELETE FROM ro_bf_ADMINISTRADOR WHERE cod_admin = '" + this.cod_admin + "'");
        }
        public int modificaradmi(ADMINISTRADOR admin)
        {
            return datoconex.GuardarDatos("UPDATE ro_bf_ADMINISTRADOR SET  cod_admin = '" + admin.cod_admin + "', nombre_admin'" + admin.nombre_admin + "', correo'" + admin.correo + "', telefono'" + admin.telefono + "'");


        }

    }
}
