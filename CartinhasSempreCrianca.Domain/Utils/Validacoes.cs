using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Utils
{
    public static class Validacoes
    {
        public static bool ValidaEmail(this string email)
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
