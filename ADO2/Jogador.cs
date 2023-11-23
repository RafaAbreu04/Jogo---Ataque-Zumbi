using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO2
{
    public class Jogador
    {

        public List<Arma> armas = new List<Arma>();
        public Arma arma1 = new Arma('A', '1', 3, 20, "Caneta");
        public Arma arma2 = new Arma('B', '2', 5, 10, "Cadeira");
        public ArmaCompanheiro arremessarCompanheiro = new ArmaCompanheiro('T', '*' , 10, 33, "Amiguinho");

        public Jogador()
        {

            armas.Add(arma1);
            armas.Add(arma2);
            armas.Add(arremessarCompanheiro);
        }

        
    }
}
