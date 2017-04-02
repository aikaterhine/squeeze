using System;

namespace Squeeze
{
     class Album
    {
         int idalbum;
         int idartista;
         string nome;
         string dt;
         string estudio;
        

        public Album() { }

        public Album(string nome) {
            this.nome = nome;
        }

        public Album(int id)
        {
            this.idalbum = id;
        }


        public Album(string nome, string estudio, string dtLancamento)
        {
            this.nome = nome;
            this.estudio = estudio;
            this.dt = dtLancamento;
        }

        public Album(int idAlbum, string nome, string estudio, string dtLancamento)
        {
            this.idalbum = idAlbum;
            this.nome = nome;
            this.estudio = estudio;
            this.dt = dtLancamento;
        }

        public Album(int idartista, int idalbum)
        {
            this.idalbum = idalbum;
            this.idartista = idartista;
        }

        public int IdAlbum { get { return this.idalbum; }  set {idalbum = value; } }
        public int Idartista { get { return this.idartista; } set { idartista = value; } }
        public string Nome { get { return this.nome; } set { nome = value; } }
        public string Estudio { get { return this.estudio; } set { estudio = value; } }
        public string Dt { get { return this.dt; } set { dt = value; } }
        
    }
}