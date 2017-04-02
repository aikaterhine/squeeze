using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.Modelo
{
    class Genero
    {
        /* TABELA ARTISTA_HAS_GENERO */
        private int idArtista;
        private int idGenero;

        /* TABELA GENERO */

        private string nomeGen;

        public Genero(int gen)
        {
            this.idGenero = gen;
        }

        public Genero(int art, int gen)
        {
            this.idArtista = art;
            this.idGenero = gen;
        }

        public Genero(int gen, string nome)
        {
            this.idGenero = gen;
            this.nomeGen = nome;
        }

        public Genero(string nome)
        {
            this.nomeGen = nome;
        }




        public int IdArtista { get { return this.idArtista; } set { this.idArtista = value; }}
        public int IdGenero { get { return this.idGenero; } set { this.idGenero = value; }}

        public string NomeGen { get { return this.nomeGen; } set { this.nomeGen = value; } }


    }
}
