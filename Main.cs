using System;
using System.Collections.Generic;
using DioReservaHotel.Utils;

namespace DioReservaHotel {

  class Program {
    public static Suite encontrarSuite(List < Suite > suites, int numeroQuarto) {
      foreach(Suite suite in suites) {
        if (suite.Numero == numeroQuarto) {
          return suite;
        }
      }
      return new Suite(-1, 0.0);
    }

    static void Main(string[] args) {

      List < Reserva > reservas = new List < Reserva > ();
      List < Suite > suites = new List < Suite > ();

      // Inicializar com suítes de exemplo;
      suites.Add(new Suite(1, 200.0));
      suites.Add(new Suite(2, 150.0));
      suites.Add(new Suite(3, 180.0));
      suites.Add(new Suite(4, 210.0));
      suites.Add(new Suite(5, 170.0));
      suites.Add(new Suite(6, 190.0));

      while (true) {
        Console.WriteLine("\n======================================");
        Console.WriteLine("Menu do Sistema de Hotel:");
        Console.WriteLine("1. Fazer uma nova reserva");
        Console.WriteLine("2. Listar todas as reservas");
        Console.WriteLine("3. Sair");
        Console.WriteLine("======================================");

        Console.Write("Digite a opção desejada: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao) {
        case 1:

          // Coletar dados do usuário
          Console.WriteLine("--------------------------------------");
          Console.Write("Digite o nome do hóspede: ");
          string nomeHospede = Console.ReadLine();
          // Coletar dados do usuário
          Console.WriteLine("--------------------------------------");
          Console.Write("Digite o número do quarto: ");
          int numeroQuarto = int.Parse(Console.ReadLine());
          // Coletar a quantidade de reservas 
          Console.WriteLine("--------------------------------------");
          Console.Write("Digite a quantidade de dias: ");
          int numeroDias = int.Parse(Console.ReadLine());
          Console.WriteLine("--------------------------------------");

          // Criar um objeto Reserva e adicionar à lista

          Pessoa novoHospede = new Pessoa(nomeHospede);
          Suite novoQuarto = encontrarSuite(suites, numeroQuarto);
          if (novoQuarto.Numero == -1) {
            Console.Write("Quarto não Encontrado ");
            return;
          }
          Reserva novaReserva = new Reserva(novoHospede, novoQuarto, numeroDias);
          Console.Write("Reserva feita com sucesso. O valor é R$" + novaReserva.CalcularValorTotal(novaReserva.Dias, novoQuarto));

          // ... atribuir valores aos atributos da novaReserva
          reservas.Add(novaReserva);

          break;
        case 2:
          Console.WriteLine("--------------------------------------");
          foreach(Reserva reserva in reservas) {
            Console.WriteLine("Hóspede:\t\t" + reserva.Hospede.Nome);
            Console.WriteLine("Suíte:\t\t\t" + reserva.Suite.Numero);
            Console.WriteLine("Quantidade de Dias:\t" + reserva.Dias);
            Console.WriteLine("Valor:\t\t\t" + reserva.ValorTotal);
            Console.WriteLine("--------------------------------------");
          }
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
