using Domain.Dto;
using Domain.Models;

namespace Services.Empacotamento;

public class EmpacotamentoService : IEmpacotamentoService
{
    public List<PedidoEmbalado> EmpacotarPedidos(List<PedidoDto> pedidos)
    {
        List<PedidoEmbalado> pedidosEmbalados = new List<PedidoEmbalado>();

        foreach (var pedido in pedidos)
        {
            pedidosEmbalados.Add(new PedidoEmbalado(pedido.PedidoId, EmpacotarProdutos(pedido.Produtos)));
        }

        return pedidosEmbalados;
    }

    private List<Caixa> EmpacotarProdutos(List<ProdutoDto> produtos)
    {
        List<CaixaDto> caixas = new();
        int volumeProdutos = produtos.Sum(p => p.Volume);

        while (volumeProdutos > 0)
        {
            if (volumeProdutos > 160000)
            {
                var caixa = new Caixa3Dto();
                volumeProdutos -= caixa.Volume;
                caixas.Add(caixa);
            }
            else if (volumeProdutos > 96000)
            {
                var caixa = new Caixa2Dto();
                volumeProdutos -= caixa.Volume;
                caixas.Add(caixa);
            }
            else
            {
                var caixa = new Caixa1Dto();
                volumeProdutos -= caixa.Volume;
                caixas.Add(caixa);
            }
        }

        foreach (var produto in produtos.OrderByDescending(p => p.Volume))
        {
            foreach (var caixa in caixas.OrderByDescending(c => c.Volume))
            {
                if (caixa.Volume >= produto.Volume) caixa.Produtos.Add(produto);
                else break;
            }
        }

        return caixas.Select(p => p.GetCaixa()).ToList();
    }
}
