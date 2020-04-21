using System;
using Microsoft.AspNetCore.Mvc;
using ApiRest.Models;
using ApiRest.Repositories;

namespace ApiRest.Controllers
{
    public class FundoCapitalController : Controller
    {
        private readonly IFundoCapitalRepository _repositorio;

        public FundoCapitalController(IFundoCapitalRepository repositorio)
        {
            _repositorio = repositorio;
        }

        //[Route("v1/[controller]")]
        [HttpGet("v1/fundocapital")]
        public IActionResult ListarFundos()
        {
            return Ok(
                _repositorio.ListarFundos());
        }

        [HttpPost("v1/fundocapital")]
        public IActionResult AdicionarFundo([FromBody]FundoCapital fundo)
        {
            _repositorio.Adicionar(fundo);
            return Ok("Fundo adicionado");
        }

        [HttpPut("v1/fundocapital/{id}")]
        public IActionResult AlterarFundo(Guid id, [FromBody]FundoCapital fundo)
        {
            var fundoAntigo = _repositorio.ObeterPorID(id);
            if (fundoAntigo == null)
            {
                return NotFound();
            }
            fundoAntigo.Nome = fundo.Nome;
            fundoAntigo.ValorAtual = fundo.ValorAtual;
            fundoAntigo.ValorNecessario = fundo.ValorNecessario;
            fundoAntigo.DataResgate = fundo.DataResgate;
            _repositorio.Alterar(fundoAntigo);
            return Ok();
        }

        [HttpDelete("v1/fundocapital/{id}")]
        public IActionResult RemoverFundo(Guid id)
        {
            var fundo = _repositorio.ObeterPorID(id);
            if (fundo == null)
            {
                return NotFound();
            }
            _repositorio.RemoverFundo(fundo);
            return Ok();
        }

        [HttpGet("v1/fundocapital/{id}")]
        public IActionResult ObterFundo(Guid id)
        {
            var fundoAntigo = _repositorio.ObeterPorID(id);
            if (fundoAntigo == null)
            {
                return NotFound();
            }
            return Ok(fundoAntigo);

        }
    }
}