using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.Modelo
{
    class Usuario
    {
        int idusuario;
        string nome;
        string email;
        string senha;
        int tipo;

        public Usuario() { }

        public Usuario(string n) {
            this.nome = n;
        }

        public Usuario(string n, string e, string s, int t)
        {
            this.nome = n;
            this.email = e;
            this.senha = s;
            this.tipo = t;
        }

        public Usuario(int id, string n, string e, string s, int t)
        {
            this.idusuario = id;
            this.nome = n;
            this.email = e;
            this.senha = s;
            this.tipo = t;
        }

        public Usuario(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public int Idusuario { get { return this.idusuario; } set { idusuario = value; } }

        public string Nome { get { return this.nome; } set { nome = value; } }

        public string Email { get { return this.email; } set { email = value; } }

        public string Senha { get { return this.senha; } set { senha = value; } }

        public int Tipo { get { return this.tipo; } set { tipo = value; } }
    }
}