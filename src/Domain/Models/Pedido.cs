using Domain.Dto;

namespace Domain.Models;

public class PedidoEmbalado
{
    public int PedidoId { get; set; }
    public List<Caixa> Caixas { get; set; }
    public PedidoEmbalado(int pedidoId, List<Caixa> caixas)
    {
        PedidoId = pedidoId;
        Caixas = caixas;
    }
}
