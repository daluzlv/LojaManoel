using Domain.Models;

namespace Domain.Dto;

public class CaixaDto
{
    public int CaixaId { get; set; }
    public List<ProdutoDto> Produtos { get; set; }
    public DimensoesDto Dimensoes { get; set; }
    public int Volume => (Dimensoes.Altura * Dimensoes.Largura * Dimensoes.Comprimento) - (Produtos?.Sum(p => p.Volume) == null ? 0 : Produtos.Sum(p => p.Volume));
    public CaixaDto()
    {
        Produtos = new();
    }

    public Caixa GetCaixa() => new Caixa(CaixaId, Produtos.Select(p => p.ProdutoId).ToList());
}

public class Caixa1Dto : CaixaDto
{
    public Caixa1Dto()
    {
        CaixaId = 1;
        Dimensoes = new DimensoesDto(30, 40, 80);
    }
}

public class Caixa2Dto : CaixaDto
{
    public Caixa2Dto()
    {
        CaixaId = 2;
        Dimensoes = new DimensoesDto(80, 50, 40);
    }
}

public class Caixa3Dto : CaixaDto
{
    public Caixa3Dto()
    {
        CaixaId = 3;
        Dimensoes = new DimensoesDto(50, 80, 60);
    }
}
