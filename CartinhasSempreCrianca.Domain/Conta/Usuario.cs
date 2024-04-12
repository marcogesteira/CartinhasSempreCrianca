using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace CartinhasSempreCrianca.Domain.Conta
{
    abstract public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        protected Usuario()
        {
        }

        protected Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = CriptografarSenha(senha);
        }

        protected string CriptografarSenha(string senhaAberta)
        {
            SHA256 criptoProvider = SHA256.Create();
            byte[] btexto = Encoding.UTF8.GetBytes(senhaAberta);
            var criptoResult = criptoProvider.ComputeHash(btexto);
            return Convert.ToHexString(criptoResult);
        }
    }
}
