using CartinhasSempreCrianca.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Conta
{
    public class Padrinho : Usuario
    {
        public string Telefone { get; set; }
        public bool Newsletter { get; set; }
        public bool BomPadrinho { get; set; }
        public bool Ativo { get; set; }

        public Padrinho(string nome, string email, string senha, string telefone, bool newsletter) : base(nome, email, senha)
        {
            if (!email.ValidarEmail())
                throw new ArgumentException("E-mail inválido");
            Telefone = telefone;
            Newsletter = newsletter;
            BomPadrinho = true;
            Ativo = true;
        }
    }
}
