using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O e-mail do usuário é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        [StringLength(35, MinimumLength = 7, ErrorMessage = "A senha deve conter entre 7 e 35 caracteres.")]
        public string Senha { get; set; }

        public int? IdTipoUsuario { get; set; }
        public TiposUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
