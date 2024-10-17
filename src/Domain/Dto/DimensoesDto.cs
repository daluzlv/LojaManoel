namespace Domain.Dto;

public class DimensoesDto
{
    public int Altura { get; set; }
    public int Largura { get; set; }
    public int Comprimento { get; set; }

    public DimensoesDto(int altura, int largura, int comprimento)
    {
        Altura = altura;
        Largura = largura;
        Comprimento = comprimento;
    }
}
