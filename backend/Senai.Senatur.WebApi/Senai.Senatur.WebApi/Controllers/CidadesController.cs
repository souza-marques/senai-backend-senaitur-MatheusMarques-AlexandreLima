using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Route("api/[controller]")]
    
    [ApiController]
    [Authorize]
    public class CidadesController : ControllerBase
    {

        private ICidadeRepository _cidadeRepository;


        public CidadesController()
        {
            _cidadeRepository = new CidadeRepository();
        }

        /// <summary>
        /// Lista todos as cidades
        /// </summary>
        /// <returns> Uma lista de cidades e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cidadeRepository.Listar());
        }

        /// <summary>
        /// Busca uma cidade através do ID
        /// </summary>
        /// <param name="id">ID da cidade que será buscada</param>
        /// <returns>Uma cidade buscada e um status code 200 - Ok</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_cidadeRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra uma nova cidade
        /// </summary>
        /// <param name="novaCidade">Objeto com as informações</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Cidades novaCidade)
        {
            _cidadeRepository.Cadastrar(novaCidade);

            return StatusCode(201);
        }


        /// <summary>
        /// Atualiza uma cidade já existente
        /// </summary>
        /// <param name="id">ID da cidade que será atualizado</param>
        /// <param name="cidadeAtualizada">Objeto com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut]
        public IActionResult Put(Cidades cidadeAtualizada)
        {
            _cidadeRepository.Atualizar(cidadeAtualizada);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta uma cidade
        /// </summary>
        /// <param name="id">ID da cidade que será deletada</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _cidadeRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}