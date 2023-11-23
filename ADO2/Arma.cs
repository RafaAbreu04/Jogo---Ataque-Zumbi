using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO2
{
    public class Arma
    {
        private int dano;
        public int Dano 
        {
            get { return dano;}
            set { dano = value; }
        }

        public int maxCartucho;
        private int cartucho;
        public int Cartucho
        {
            get { return cartucho; }
            set { cartucho = value; }
        }

        public string armaName;

        public char keyTiro;
        public char keyRecarregar;
    

        public Arma(char _tiroKey, char _recarregarKey , int _dano, int _cartucho, string _armaName)
        {
            armaName = _armaName;
            keyTiro = _tiroKey;
            keyRecarregar = _recarregarKey;
            dano = _dano;

            maxCartucho = _cartucho;
            Cartucho = maxCartucho;
        }


        public virtual void Recarregar()
        {
            Cartucho = maxCartucho;   
        }

        public void GastarBala()
        {
            Console.WriteLine("Atirou");
            Cartucho -=  1;
        }

    }
}
