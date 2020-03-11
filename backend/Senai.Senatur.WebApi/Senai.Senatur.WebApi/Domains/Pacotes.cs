using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Pacotes
    {
        public int IdPacote { get; set; }

        [Required(ErrorMessage = "O nome do pacote é necessário")]
        public string NomePacote { get; set; }

        [Required(ErrorMessage = " A descrição do pacote é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A data de ida do pacote do é obrigatória")]
        [DataType(DataType.Date)]
        public DateTime DataIda { get; set; }

        [Required(ErrorMessage = "A data de volta do pacote do é obrigatória")]
        [DataType(DataType.Date)]
        public DateTime DataVolta { get; set; }

        [Required(ErrorMessage = "O preço do pacote é obrigatório!")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }


        public bool? Ativo { get; set; }

        public int? IdCidade { get; set; }

        public Cidades IdCidadeNavigation { get; set; }
    }
}
