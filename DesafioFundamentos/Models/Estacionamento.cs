using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTADO*
            Console.Write("Digite a placa do veículo para estacionar: ");
            string veiculo = Console.ReadLine();
            veiculos.Add(veiculo); //adicionar veiculo

            Console.WriteLine($"\nVeiculo de placa {veiculo} adicionado.");
        }

        public void RemoverVeiculo()
        {
            //lista os veiculos
            Console.WriteLine();
            ListarVeiculos();


            Console.Write("\nDigite a placa do veículo para remover: ");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO*
            string placa = Console.ReadLine(); //obter placa

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTADO*
                int horas = Convert.ToInt32(Console.ReadLine()); //obter tempo estacionado em horas
                
                decimal valorTotal = precoInicial + precoPorHora * horas; // valorTotal calc

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTADO*
                veiculos.Remove(placa); //remove veiculo

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTADO*

                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
