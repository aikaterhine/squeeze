namespace Squeeze.DAO
{
    public class Faixa
    {
        int id;
        int idalbum;
        string nome;
        string duracao;


        public Faixa(string nome, string duracao, int album)
        {
            this.nome = nome;
            this.duracao = duracao;
            this.idalbum = album;


        }
        public Faixa(int id, string nome, string duracao, int album)
        {
            this.id = id;
            this.nome = nome;
            this.duracao = duracao;
            this.idalbum = album;


        }
        public int Id { get { return this.id; } set { id = value; } }

        public string Nome { get { return this.nome; } set { nome = value; } }

        public string Duracao { get { return this.duracao; } set { duracao = value; } }

        public int Idalbum { get { return this.idalbum; } set { idalbum = value; } }

    }
}