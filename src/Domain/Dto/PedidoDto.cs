namespace Domain.Dto;

public class PedidoDto
{
    public int PedidoId { get; set; }
    public List<ProdutoDto> Produtos { get; set; }
}
