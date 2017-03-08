using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.Modelo
{
    class Artista
    {
        int idartista;
        string nome;
        string nascimento;
        string grupo;
        string genero;
        string carreira;
     

        public Artista(string n, string nas, string gr, string car, string gen)
        {
            this.nome = n;
            this.nascimento = nas;
            this.grupo = gr;
            this.carreira = car;
            this.genero = gen;
        }

        public Artista(int id, string n, string nas, string gr, string car, string gen)
        {
            this.idartista = id;
            this.nome = n;
            this.nascimento = nas;
            this.grupo = gr;
            this.carreira = car;
            this.genero = gen;
        }

        public int IdArtista { get { return this.idartista; } set { idartista = value; } }

        public string Nome { get { return this.nome; } set { nome = value; } }

        public string Nascimento { get { return this.nascimento; } set { nascimento = value; } }

        public string Grupo { get { return this.grupo; } set { grupo = value; } }

        public string Carreira { get { return this.carreira; } set {  carreira = value; } }

        public string Genero { get { return this.genero; } set { genero = value; } }

    }
}
