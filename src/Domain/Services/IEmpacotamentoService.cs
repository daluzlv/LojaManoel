using Domain.Dto;
using Domain.Models;

namespace Services.Empacotamento;

public interface IEmpacotamentoService
{
    List<PedidoEmbalado> EmpacotarPedidos(List<PedidoDto> pedidos);
}
