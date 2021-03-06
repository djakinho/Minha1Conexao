using Microsoft.AspNetCore.Mvc;
using Minha1Conexao.Data.Interface;
using Minha1Conexao.Domain.Model;
using Minha1Conexao.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUsuarioRepository _usuariorepo;
        public HomeController(IUsuarioRepository usuarioRepo)
        {
            _usuariorepo = usuarioRepo;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] Usuario usuarioDto)
        {
            try
            {
                if (string.IsNullOrEmpty(usuarioDto.Nome) || string.IsNullOrEmpty(usuarioDto.Senha))
                    return BadRequest("Nome e/ou senha não devem ser nulas.");

                var usuario = _usuariorepo.SelecionarPorNomeESenha(usuarioDto.Nome, usuarioDto.Senha);
                if (usuario == null)
                    return NotFound("Nome e/ou Senha inválido(s).");

                var token = TokenService.GerarToken(usuario);

                return Ok(token);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}