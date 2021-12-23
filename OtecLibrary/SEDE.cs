using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class SEDE
    {
        private int id_sede;
        private string Nom_sede;

        public SEDE()
        {

        }

        public SEDE(int id_sede, string nom_sede)
        {
            this.id_sede = id_sede;
            this.Nom_sede = nom_sede;
        }

        public int Id_sede { get => id_sede; set => id_sede = value; }
        public string Nom_sede1 { get => Nom_sede; set => Nom_sede = value; }
    }

}
