using Domain.Dto;

namespace Domain.Models;

public class Caixa
{
    public int CaixaId { get; set; }
    public List<string> Produtos { get; set; }
    public Caixa(int caixaId, List<string> produtos)
    {
        CaixaId = caixaId;
        Produtos = produtos;
    }
}
