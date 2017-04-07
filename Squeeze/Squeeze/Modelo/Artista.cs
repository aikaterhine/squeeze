using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.Modelo
{
    class Artista
    {
        int id;
        int fav;
        int qntd;
        string nome;
        string dt;
        string img;

        public Artista() { }

        public Artista(string n) {
            this.nome = n;
        }

        public Artista(int id)
        {
            this.id = id;
        }

        public Artista(int fav, int id)
        {
            this.fav = fav;
            this.id = id;
        }

        public Artista(string n, string dt)
        {
            this.nome = n;
            this.dt = dt;
        }

        public Artista(int id, string n, string dt)
        {
            this.id = id;
            this.nome = n;
            this.dt = dt;
        }

        public Artista(string n, string dt, string img)
        {
            this.nome = n;
            this.dt = dt;
            this.img = img;
        }

        public Artista(int id, string n, string dt, string img)
        {
            this.id = id;
            this.nome = n;
            this.dt = dt;
            this.img = img;
        }

        public int Id { get { return this.id; } set { id = value; } }

        public string Nome { get { return this.nome; } set { nome = value; } }

        public string Dt { get { return this.dt; } set { dt = value; } }

        public int Fav { get { return this.fav; } set { fav = value; } }

        public string Img { get { return this.img; } set { img = value; } }


    }
}
