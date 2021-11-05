using System;
using System.Collections.Generic;

namespace PaP_API.Models
{
    public class Ponto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime PontoHora { get; set; }


        public Ponto(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
            PontoHora = DateTime.Now;
        }
        public Ponto()
        {
        }
    }
}
