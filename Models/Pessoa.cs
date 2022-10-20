using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCamp___Pottencial.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }

        public void Aprensentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e moro em {Cidade}");
        }
    }
}