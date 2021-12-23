using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class CURSOS
    {
        private string Nom_curso;
        private int cod_curso;
        




        public string Nom_curso1 { get => Nom_curso; set => Nom_curso = value; }
        public int Cod_curso { get => cod_curso; set => cod_curso = value; }

        public CURSOS()
        {

        }
    

        public CURSOS(string nom_curso, int cod_curso)
        {
            this.Nom_curso = nom_curso;
            this.cod_curso = cod_curso;
        }
    }
}
