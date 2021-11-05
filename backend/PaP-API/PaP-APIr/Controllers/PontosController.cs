using Microsoft.AspNetCore.Mvc;
using PaP_API.Data;
using PaP_API.Models;
using PaP_APIr.Interfaces;
using System.Collections;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PaP_APIr.Controllers
{
    [ApiController]
    [Route("api/ponto")]
    public class PontosController : ControllerBase
    {
        protected readonly IPontoRepository _pontoRepository;

        public PontosController(IPontoRepository pontoRepository)
        {
            _pontoRepository = pontoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarPonto([FromBody] PontoReq pontoReq)

        {
            //var pontos = await _pontoRepository.ObterPorAtributo(ponto => ponto.CPF == pontoReq.CPF);

            //if (pontos == null) return BadRequest();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            Ponto ponto = new(pontoReq.Nome, pontoReq.CPF);

            await _pontoRepository.Adicionar(ponto);

            return Ok();

        }

        [HttpGet("{cpf}")]
        public async Task<IActionResult> ObterPontosPorPeriodo(string cpf)
        {
            var pontos = await _pontoRepository.Buscar(pontos => pontos.CPF == cpf);

            if (pontos == null) return BadRequest();

         
            return Ok(pontos);
        }

        //switch (dias)
        //{
        //    case 0: var pontos = await _pontoRepository.Buscar(pontos => pontos.PontoHora.Date == System.DateTime.Now.Date);
        //        return Ok(pontos);
        //        break;
        //    case 3: var pontosTresDias = await _pontoRepository.Buscar(pontos => pontos.PontoHora.Date > System.DateTime.Now.Date.AddDays(-3));
        //        return Ok(pontosTresDias);
        //        break;
        //    case 5:
        //        var pontosCincoDias = await _pontoRepository.Buscar(pontos => pontos.PontoHora.Date > System.DateTime.Now.Date.AddDays(-5));
        //        return Ok(pontosCincoDias);
        //        break;
        //    case 10:
        //        var pontosDezDias = await _pontoRepository.Buscar(pontos => pontos.PontoHora.Date > System.DateTime.Now.Date.AddDays(-10));
        //        return Ok(pontosDezDias);
        //        break;
        //    case 15:
        //        var pontosQuinzeDias = await _pontoRepository.Buscar(pontos => pontos.PontoHora.Date > System.DateTime.Now.Date.AddDays(-15));
        //        return Ok(pontosQuinzeDias);
        //        break;
        //    case 30:
        //        var pontosTrintaDias = await _pontoRepository.Buscar(pontos => pontos.PontoHora.Date > System.DateTime.Now.Date.AddDays(-30));
        //        return Ok(pontosTrintaDias);
        //        break;

        //    default: return BadRequest();
        //        break;
        //}

    }
}
