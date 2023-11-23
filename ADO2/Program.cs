using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zumbi[] zumbis = { new Zumbi(1, "Zumbifly"), new Zumbi(4, "Zumbicão"), new Zumbi(7, "Clássico"), new Zumbi(12, "Híbrido") };
            Jogador jogador = new Jogador();            
            string[] entradas = { "Porta 1", "Porta 2", "Janela" };


            while (true)
            {
                Zumbi zumbiTemporario = SpawnarZumbi(zumbis);
                Random random = new Random();
                int entradasIndex = random.Next(0, entradas.Length);
                Console.WriteLine($"Apareceu um {zumbiTemporario.Nome} na entrada {entradas[entradasIndex]} ");

                Console.WriteLine("Digite a tecla da arma que deseja usar.\n");
                Console.WriteLine("Caneta: A");
                Console.WriteLine("Caneta: B");
                Console.WriteLine("Caneta: T");


                Combate(EscolherArma(jogador), zumbiTemporario);

                Console.ReadLine();
            }

            

            
        }

        public static void Combate(Arma _arma, Zumbi _zumbi)
        {
            while(_zumbi.Vida > 0)
            {
                if (_arma.Cartucho > 0)
                {
                    Console.WriteLine($"\nDigite {_arma.keyTiro} para atirar");
                    if (char.Parse(Console.ReadLine().ToUpper()) == _arma.keyTiro)
                    {
                        _arma.GastarBala();
                        _zumbi.TomarDano(_arma.Dano);
                        Console.WriteLine($"Balas no cartucho (ou companheiros se você esolheu a arremessar amiguinho): {_arma.Cartucho}");
                    }
                    else
                    {
                        Console.WriteLine("Tecla errada!");
                        return;
                    }

                }
                else if (_arma is ArmaCompanheiro && _arma.Cartucho <= 0)
                {
                    Console.WriteLine("Acabou os companheiros");
                    return;
                }
                else
                {
                    while (_arma.Cartucho <= 0)
                    {
                        Console.WriteLine("Não tem bala!");
                        Console.WriteLine($"Aperte a tecla {_arma.keyRecarregar} para recarregar a arma.");
                        if (char.Parse(Console.ReadLine().ToUpper()) == _arma.keyRecarregar)
                        {
                            _arma.Recarregar();
                        }
                    }

                }

                Console.WriteLine($"Zumbi ainda tem {_zumbi.Vida} de vida.");
            }

            Console.WriteLine("Zumbi morreu.");

        }

        public static Zumbi SpawnarZumbi(Zumbi[] arrayZumbis)
        {
            Random random = new Random();
            int zumbiIndex = random.Next(0, arrayZumbis.Length);

            return arrayZumbis[zumbiIndex];
        }

        public static Arma EscolherArma(Jogador _jogador)
        {
            Console.Write("Escolha uma arma: ");
            char teclaSelecionada = char.Parse(Console.ReadLine().ToUpper());

            for (int i = 0; i < _jogador.armas.Count; i++)
            {
                if (_jogador.armas[i].keyTiro == teclaSelecionada)
                {
                    Console.WriteLine($"Arma selecionada: {_jogador.armas[i].armaName}");

                    return _jogador.armas[i];
                }
            }
            Console.WriteLine("Não retornou nenhuma arma!");
            return null;
        }
    }
}
