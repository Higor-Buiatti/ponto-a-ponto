using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaP_API.Models
{
    public class PontoReq
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }

        public PontoReq(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
        public PontoReq()
        {
        }
    }
}
