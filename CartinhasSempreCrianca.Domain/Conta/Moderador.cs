using CartinhasSempreCrianca.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Conta
{
    public class Moderador : Usuario
    {
        public bool Ativo { get; set; }

        public Moderador() : base()
        {
            
        }

        public Moderador(string nome, string email, string senha) : base(nome, email, senha)
        {
            if (!email.ValidarEmail())
                throw new ArgumentException("E-mail inválido");
            Ativo = true; 
        }        
    }
}
