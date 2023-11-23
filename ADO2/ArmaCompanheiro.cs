using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO2
{
    public class ArmaCompanheiro : Arma
    {
        
        public ArmaCompanheiro(char _tiroKey, char _recarregarKey, int _dano, int _cartucho, string _armaName) : base(_tiroKey, _recarregarKey, _dano, _cartucho, _armaName)
        {
            
        }

        public override void Recarregar()
        {
            Console.WriteLine("Companheiro não recarrega!");
        }
    }
}
