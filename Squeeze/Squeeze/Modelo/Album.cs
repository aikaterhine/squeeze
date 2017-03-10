using System;

namespace Squeeze
{
     class Album
    {
         int id;
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
            this.id = id;
        }


        public Album(string nome, string estudio, string dtLancamento)
        {
            this.nome = nome;
            this.estudio = estudio;
            this.dt = dtLancamento;
        }

        public Album(int idAlbum, string nome, string estudio, string dtLancamento)
        {
            this.id = idAlbum;
            this.nome = nome;
            this.estudio = estudio;
            this.dt = dtLancamento;
        }

        public Album(int id, int idartista)
        {
            this.id = id;
            this.idartista = idartista;
        }

        public int Id { get { return this.id; }  set {id = value; } }
        public int Idartista { get { return this.idartista; } set { idartista = value; } }

        public string Nome { get { return this.nome; } set { nome = value; } }
        public string Estudio { get { return this.estudio; } set { estudio = value; } }
        public string Dt { get { return this.dt; } set { dt = value; } }
        
    }
}