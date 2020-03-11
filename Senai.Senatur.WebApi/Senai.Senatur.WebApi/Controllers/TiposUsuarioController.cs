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
    public class TiposUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tuRepository;


        public TiposUsuarioController()
        {
            _tuRepository = new TipoUsuarioRepository();
        }


        /// <summary>
        /// Lista todos os tipos de usuário
        /// </summary>
        /// <returns>Uma lista de tipos de usuário e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tuRepository.Listar());
        }


        /// <summary>
        /// Busca um tipo de usuário através do ID
        /// </summary>
        /// <param name="id">ID do tipo de usuário que será buscado</param>
        /// <returns>Um tipo de usuário buscado e um status code 200 - Ok</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_tuRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um novo tipo de usuário
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto novoJogo que será cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(TiposUsuario novoTipoUsuario)
        {
            _tuRepository.Cadastrar(novoTipoUsuario);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza um tipo de usuário existente
        /// </summary>
        /// <param name="id">ID do jogo que será atualizado</param>
        /// <param name="tuAtualizado">Objeto com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut]
        public IActionResult Put(TiposUsuario tuAtualizado)
        {
            _tuRepository.Atualizar( tuAtualizado);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um tipo de usuário existente através do id
        /// </summary>
        /// <param name="id">ID do tipousuario que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tuRepository.Deletar(id);

            return StatusCode(204);
        }
    }

}