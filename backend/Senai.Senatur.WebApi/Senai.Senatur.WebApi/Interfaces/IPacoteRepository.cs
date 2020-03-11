using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IPacoteRepository
    {

        List<Pacotes> Listar();

        void Cadastrar(Pacotes novoPacote);

        Pacotes BuscarPorId(int id);

        void Atualizar(Pacotes pacoteAtualizado);

        void Deletar(int id);

        List<Pacotes> ListarAtivos();

        List<Pacotes> ListarInativos();

        List<Pacotes> ListarPorCidade(int id);

        //List<Pacotes> ListarPreçoCrescente();

        //List<Pacotes> ListarPreçoDecrescente();
    }
}
