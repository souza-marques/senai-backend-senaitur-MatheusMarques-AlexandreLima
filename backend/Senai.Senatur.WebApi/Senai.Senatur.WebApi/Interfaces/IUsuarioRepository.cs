using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuarios> Listar();

        void Cadastrar(Usuarios novoUsuario);

        Usuarios BuscarPorId(int id);

        void Atualizar(Usuarios usuarioAtualizado);
        
        void Deletar(int id);

        List<Usuarios> ListarComTiposUsuario();

        Usuarios BuscarPorEmailSenha(string email, string senha);
    }
}
