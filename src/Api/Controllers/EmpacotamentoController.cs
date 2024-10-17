using Domain.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Empacotamento;

namespace Api.Controllers;

[ApiController]
[Route("v1/empacotamento")]
[Authorize]
public class EmpacotamentoController : ControllerBase
{
    private readonly IEmpacotamentoService _service;
    public EmpacotamentoController(IEmpacotamentoService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Post(List<PedidoDto> pedidoDtos) => 
        Ok(_service.EmpacotarPedidos(pedidoDtos));
}
