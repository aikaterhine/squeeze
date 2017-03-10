namespace Squeeze.DAO
{
    public class Faixa
    {
        int id;
        string nome;
        string duracao;
        string idalbum;


        public Faixa(string nome, string duracao, string album_faixa)
        {
            this.nome = nome;
            this.duracao = duracao;
            this.idalbum = album_faixa;


        }
        public Faixa(int id, string nome, string duracao, string album_faixa)
        {
            this.id = id;
            this.nome = nome;
            this.duracao = duracao;
            this.idalbum = album_faixa;


        }
        public int Id { get { return this.id; } set { id = value; } }

        public string Nome { get { return this.nome; } set { nome = value; } }

        public string Duracao { get { return this.duracao; } set { duracao = value; } }

        public string Idalbum { get { return this.idalbum; } set { idalbum = value; } }

    }
}