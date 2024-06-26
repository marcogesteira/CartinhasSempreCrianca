﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Cartinha
{
    public class Instituicao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual Diretor Diretor { get; set; }
        public virtual IList<Crianca> Criancas { get; set; } = new List<Crianca>();

        public Instituicao()
        {
            
        }

        public Instituicao(string nome, Diretor diretor)
        {
            Nome = nome;
            Ativo = true;
            Diretor = diretor;
        }

        public void AdicionarCrianca(Crianca crianca)
        {
            this.Criancas.Add(crianca);
        }
    }
}
