using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Cidades
    {
        public Cidades()
        {
            Pacotes = new HashSet<Pacotes>();
        }

        public int IdCidade { get; set; }

        [Required(ErrorMessage = "O nome da cidade é obrigatória!")]
        public string NomeCidade { get; set; }

        public ICollection<Pacotes> Pacotes { get; set; }
    }
}
