using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacoteRepository _pacoteRepository;


        public PacotesController()
        {
            _pacoteRepository = new PacoteRepository();
        }


        /// <summary>
        /// Lista todos os pacotes
        /// </summary>
        /// <returns>Uma lista de pacotes e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pacoteRepository.Listar());
        }

        /// <summary>
        /// Busca um pacote através do ID
        /// </summary>
        /// <param name="id">ID do pacote que será buscado</param>
        /// <returns>Um pacote buscado e um status code 200 - Ok</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_pacoteRepository.BuscarPorId(id));
        }


        /// <summary>
        /// Cadastra um novo pacote
        /// </summary>
        /// <param name="novoPacote">Objeto novoPacote que será cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Pacotes novoPacote)
        {
            _pacoteRepository.Cadastrar(novoPacote);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza um pacote já existente
        /// </summary>
        /// <param name="id">ID do pacote que será atualizado</param>
        /// <param name="pacoteAtualizado">Objeto que contém as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut]
        public IActionResult Put( Pacotes pacoteAtualizado)
        {
            _pacoteRepository.Atualizar( pacoteAtualizado);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um pacote existente
        /// </summary>
        /// <param name="id">ID do paocte que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pacoteRepository.Deletar(id);

            return StatusCode(204);
        }

    }
}