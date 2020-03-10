using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        SenaturContext ctx = new SenaturContext();

        public void Atualizar(Cidades cidadeAtualizada)
        {
            ctx.Cidades.Update(cidadeAtualizada);

            ctx.SaveChanges();
        }

        public Cidades BuscarPorId(int id)
        {
            return ctx.Cidades.FirstOrDefault(c => c.IdCidade == id);
        }

        public void Cadastrar(Cidades novaCidade)
        {
            ctx.Cidades.Add(novaCidade);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Cidades x = ctx.Cidades.Find(id);

            ctx.Cidades.Remove(x);

            ctx.SaveChanges();
        }

        public List<Cidades> Listar()
        {
            return ctx.Cidades.ToList();
        }
    }
}
