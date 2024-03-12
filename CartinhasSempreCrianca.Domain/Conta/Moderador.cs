using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Conta
{
    internal class Moderador : Usuario
    {
        public bool Ativo { get; set; }

        public Moderador(string nome, string email, string senha) : base(nome, email, senha)
        {
            Ativo = true; 
        }

        
    }
}
