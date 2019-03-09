using System;
using System.Globalization;

namespace primeiroProjeto
{
    class Program
    {
        private static readonly int nTombo;

        static void Main(string[] args)
        {
            ControleParimonio controle;
                  //  double ntombo = 0;

            Console.Write("deseja incluir um patrimonio (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            int ntombo;
            ntombo = 0;
            if (resp == 's' || resp == 'S')
            {
                do
                {
                    ntombo++;
                    Console.Write("Entre com o nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Entre com a marca do produto: ");
                    string marcaId = Console.ReadLine();
                    Console.Write("Entre com a descrição do produto: ");
                    string descricao = Console.ReadLine();
                    controle = new ControleParimonio(nome, marcaId, descricao, nTombo);
                    Console.Write("deseja incluir um patrimonio (s/n)? ");
                    resp = char.Parse(Console.ReadLine());
                }
                while (resp == 's' || resp == 'S');
            }
            else
            {
                Console.WriteLine("Obrigada!");
            }
        }
    }
}
