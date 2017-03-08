using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze.Modelo
{
    class Carreira
    {
        private int id;
        private string nome;

        public Carreira(string nomeC)
        {
            this.nome = nomeC;
        }

        public Carreira(int id, string nomeC)
        {
            this.id = id;
            this.nome = nomeC;
        }

        public int Id { get { return this.id; } set { id = value; } }
        public string Nome { get { return this.nome; } set { nome = value; } }


    }
}
