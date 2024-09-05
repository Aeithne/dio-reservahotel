using System;
using System.Collections.Generic;

namespace DioReservaHotel.Utils {
  public class Pessoa {
    public string Nome {
      get;
      set;
    }
  }

  public class Suite {
    public int Numero {
      get;
      set;
    }
    public double ValorDiaria {
      get;
      set;
    }

    public Suite(int numero, double valor) {
      Numero = numero;
      ValorDiaria = valor;
    }
  }

  public class Reserva {
    public Pessoa Hospede {
      get;
      set;
    }
    public Suite Suite {
      get;
      set;
    }
    public int Dias {
      get;
      set;
    }

    public double CalcularValorTotal(int totalDias, Suite suite) {
      double valorTotal = totalDias * suite.ValorDiaria;
      if (totalDias > 10) valorTotal *= 0.9; // Desconto de 10%
      return valorTotal;
    }
  }
}
