using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
   
        public class UsuarioRepository : IUsuarioRepository

       {
        SenaturContext ctx = new SenaturContext();

        public void Atualizar(Usuarios usuarioAtualizado)
        {
            ctx.Usuarios.Update(usuarioAtualizado);

            ctx.SaveChanges();
        }

        public Usuarios BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuarios usuarios = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(usuarios);

            ctx.SaveChanges();
        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
