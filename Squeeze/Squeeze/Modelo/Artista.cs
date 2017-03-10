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
        string dt;
        int tipoc;

        public Artista(string n) {
            this.nome = n;
        }


        public Artista(string n, int t, string dt)
        {
            this.nome = n;
            this.tipoc = t;
            this.dt = dt;

        }

        public Artista(int id, string n, int t, string dt)
        {
            this.idartista = id;
            this.nome = n;
            this.tipoc = t;
            this.dt = dt;
        }

        public Artista() { }
        public int IdArtista { get { return this.idartista; } set { idartista = value; } }

        public string Nome { get { return this.nome; } set { nome = value; } }

        public int Tipoc { get { return this.tipoc; } set { tipoc = value; } }

        public string Dt { get { return this.dt; } set { dt = value; } }

    }
}
