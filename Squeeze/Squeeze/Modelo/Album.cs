using System;

namespace Squeeze
{
     class Album
    {
         int id;
         string albuns;
         string dimensoes;
         string dt;
         string estudio;

        public Album(string album, string estudio, string dtLancamento, string dimensoes)
        {
            this.albuns = album;
            this.estudio = estudio;
            this.dt = dtLancamento;
            this.dimensoes = dimensoes;
        }

        public Album(int idAlbum, string album, string estudio, string dtLancamento, string dimensoes)
        {
            this.id = idAlbum;
            this.albuns = album;
            this.estudio = estudio;
            this.dt = dtLancamento;
            this.dimensoes = dimensoes;
        }

        public int Id { get { return this.id; }  set {id = value; } }
        public string Albuns { get { return this.albuns; } set { albuns = value; } }
        public string Estudio { get { return this.estudio; } set { estudio = value; } }
        public string Dt { get { return this.dt; } set { dt = value; } }
        public string Dimensoes { get { return this.dimensoes; } set { dimensoes = value; } }

        public frmPrincipal MdiParent { get; internal set; }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}