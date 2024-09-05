using System;
using System.Collections.Generic;
using DioReservaHotel.Utils;

namespace DioReservaHotel {

  class Program {
    static void Main(string[] args) {
      List < Reserva > reservas = new List < Reserva > ();

      while (true) {
        Console.WriteLine("\nMenu do Sistema de Hotel:");
        Console.WriteLine("1. Fazer uma nova reserva");
        Console.WriteLine("2. Listar todas as reservas");
        Console.WriteLine("3. Sair");

        Console.Write("Digite a opção desejada: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao) {
        case 1:
          // Lógica para fazer uma nova reserva
          // ... (coletar dados do usuário, criar um objeto Reserva e adicionar à lista)
          break;
        case 2:
          // Lógica para listar todas as reservas
          // ... (iterar sobre a lista de reservas e exibir os dados)
          break;
        case 3:
          Console.WriteLine("Saindo do sistema...");
          return;
        default:
          Console.WriteLine("Opção inválida. Tente novamente.");
          break;
        }
      }
    }
  }
}
