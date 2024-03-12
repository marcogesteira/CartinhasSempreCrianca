﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CartinhasSempreCrianca.Domain.Conta
{
    abstract internal class Usuario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        protected Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public bool ValidaEmail(string email)
        {
            string padrao = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            if (Regex.IsMatch(email, padrao)) 
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}