using System;
using System.Collections.Generic;

namespace DioReservaHotel.Utils
{
public class Pessoa
  {
    public string Nome { get; set; }
	  public Pessoa(string nome) {
		this.Nome = nome;
	}
}

public class Suite
{
    public int Numero { get; set; }
    public double ValorDiaria { get; set; }	
	  public Suite(int numero, double valor) {
		this.Numero = numero;
		ValorDiaria = valor;
	}
}

public class Reserva
{
    public Pessoa Hospede { get; set; }
    public Suite Suite { get; set; }
    public int Dias { get; set; }
	  public double Valor { get; set; }
	
	  public Reserva(Pessoa p, Suite s, int d) {
		this.Hospede = p;
		this.Suite = s;
		this.Dias = d;
		this.Valor = CalcularValorTotal(d, s);
	}
    
	public double CalcularValorTotal(int totalDias, Suite suite) {
        double valorTotal = totalDias * suite.ValorDiaria;
        if (totalDias > 10) valorTotal *= 0.9; // Desconto de 10%
        return valorTotal;
    }
  }
}
