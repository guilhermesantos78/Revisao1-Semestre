using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Funcionario : Pessoa 
    {
        private int Matricula { get; set; }
        public string placaVeiculo { get; set; }

        public bool verificarVeiculo(Automovel automovel)
        {
            if (placaVeiculo.Length ==  7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RetornaMatricula()
        {
            Console.WriteLine("Digite sua matricula");

            int MatriculaRetornada = int.Parse(Console.ReadLine());

            return MatriculaRetornada;
        }
    }
}
