namespace Squeeze.DAO
{
    public class Faixa
    {
        int isbn;
        string nome;
        string duracao;
        string artista_faixa;
        string album_faixa;


        public Faixa(string nome, string duracao, string artista_faixa, string album_faixa)
        {
            this.nome = nome;
            this.duracao = duracao;
            this.artista_faixa = artista_faixa;
            this.album_faixa = album_faixa;


        }
        public Faixa(int id, string nome, string duracao, string artista_faixa, string album_faixa)
        {
            this.isbn = id;
            this.nome = nome;
            this.duracao = duracao;
            this.artista_faixa = artista_faixa;
            this.album_faixa = album_faixa;


        }
        public int Isbn { get { return this.isbn; } set { isbn = value; } }

        public string Nome { get { return this.nome; } set { nome = value; } }

        public string Duracao { get { return this.duracao; } set { duracao = value; } }

        public string Artista_faixa { get { return this.artista_faixa; } set { artista_faixa = value; } }

        public string Album_faixa { get { return this.album_faixa; } set { album_faixa = value; } }

    }
}