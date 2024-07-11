using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Pessoa
    {
        public string nome { get; set; }
        public bool Contatar()
        {
            bool verify = true;
            Console.WriteLine("Usuario Contatado com sucesso");
            return verify;
        }
    }
}
