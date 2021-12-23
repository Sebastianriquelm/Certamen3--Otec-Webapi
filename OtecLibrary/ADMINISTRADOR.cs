using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class ADMINISTRADOR
    {

        private string nombre_admin;
        private string correo;
        private int telefono;



        public string Nombre_admin { get => nombre_admin; set => nombre_admin = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Telefono { get => telefono; set => telefono = value; }


        public ADMINISTRADOR()
        {

        }

        public ADMINISTRADOR(string nombre_admin, string correo, int telefono, SEDE sede)
        {
            this.nombre_admin = nombre_admin;
            this.correo = correo;
            this.telefono = telefono;

        }
    }
}
