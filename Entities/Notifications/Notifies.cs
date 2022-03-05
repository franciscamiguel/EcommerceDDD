using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
   public class Notifies
    {
        public Notifies()
        {
            Notitycoes = new List<Notifies>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifies> Notitycoes;

        public bool validarpropriedadeString(  string valor, string nomepropriedade)
        {
            if(string.IsNullOrWhiteSpace(valor) ||string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatorio",
                    NomePropriedade = nomepropriedade
                });

                return false;
            }
            return true;
        }


        public bool validarpropriedadeInt(int valor, string nomepropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "O valor deve ser maior que 0",
                    NomePropriedade = nomepropriedade
                });

                return false;
            }
            return true;
        }


        public bool validarpropriedadeDecimal(decimal valor, string nomepropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "O valor deve ser maior que 0",
                    NomePropriedade = nomepropriedade
                });

                return false;
            }
            return true;
        }


    }
}
