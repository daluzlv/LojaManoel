namespace Domain.Dto;

public class ProdutoDto
{
    public string ProdutoId { get; set; }
    public DimensoesDto Dimensoes { get; set; }
    public int Volume => Dimensoes.Altura * Dimensoes.Largura * Dimensoes.Comprimento;

    public ProdutoDto(string produtoId, DimensoesDto dimensoes)
    {
        ProdutoId = produtoId;
        Dimensoes = dimensoes;
    }
}
