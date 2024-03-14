using CartinhasSempreCrianca.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Conta
{
    internal class Moderador : Usuario
    {
        public Guid Id { get; private set; }
        public bool Ativo { get; private set; }

        public Moderador(string nome, string email, string senha) : base(nome, email, senha)
        {
            if (!email.ValidaEmail())
                throw new ArgumentException("Favor inserir um e-mail válido");
            
            Id = Guid.NewGuid();
            Ativo = true; 
        }

        //Falta incluir lógica para inativar e Ativar
        public void InativaModerador(Guid id)
        {

        }
        
    }
}
