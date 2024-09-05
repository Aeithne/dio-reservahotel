namespace DioReservaHotel.Utils
{
public class Pessoa
{
    public string Nome { get; set; }
}

public class Suite
{
    public int Numero { get; set; }
    public double ValorDiaria { get; set; }
}

public class Reserva
{
    public Pessoa Hospede { get; set; }
    public Suite Suite { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaida { get; set; }

    public double CalcularValorTotal()
    {
        int dias = (DataSaida - DataEntrada).Days;
        double valorTotal = dias * Suite.ValorDiaria;
        if (dias > 10)
        {
            valorTotal *= 0.9; // Desconto de 10%
        }
        return valorTotal;
    }
}
}
