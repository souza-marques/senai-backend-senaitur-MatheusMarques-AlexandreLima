using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface ICidadeRepository
    {

        List<Cidades> Listar();

        void Deletar(int id);

        void Cadastrar(Cidades novaCidade);

        Cidades BuscarPorId(int id);

        void Atualizar(Cidades cidadeAtualizada);
    }
}
