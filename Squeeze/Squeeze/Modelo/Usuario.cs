using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.Modelo
{
    class Usuario
    {
        string idusuario;
        string nome;
        string email;
        string senha;

        public Usuario(string n, string e, string s)
        {
            this.nome = n;
            this.email = e;
            this.senha = s;
        }

        public Usuario(string id, string n, string e, string s)
        {
            this.idusuario = id;
            this.nome = n;
            this.email = e;
            this.senha = s;
        }

        public Usuario(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public string Idusuario { get { return this.idusuario; } set { idusuario = value; } }

        public string Nome { get { return this.nome; } set { nome = value; } }

        public string Email { get { return this.email; } set { email = value; } }

        public string Senha { get { return this.senha; } set { senha = value; } }


    }
}