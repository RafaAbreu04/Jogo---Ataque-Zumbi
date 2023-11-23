using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO2
{
    public class Zumbi
    {
        private int vida;

        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Zumbi(int _vida, string _nome)
        {
            vida = _vida;
            nome = _nome;
        }

        public void TomarDano(int _danoRecebido)
        {
            Console.WriteLine($"Zumbi tomou {_danoRecebido} de dano e tinha {Vida} de vida. ");
            vida -= _danoRecebido;
        }


    }
}

