using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFundamentos.Models;
using DesafioFundamentos.Repository;

namespace DesafioFundamentos.Controller
{
    public class EstacionamentoController : EstacionamentoRepository
    {
        private List<Veiculo> _veiculos = new List<Veiculo>();

        public void AdicionarVeiculo(string placa, string marca, string modelo, int tipoVeiculo)
        {
            if (tipoVeiculo == 1)
            {
                _veiculos.Add(new Automovel(placa, marca, modelo));
            }
            else if (tipoVeiculo == 2)
            {
                _veiculos.Add(new Motocicleta(placa, marca, modelo));
            }
            else
            {
                _veiculos.Add(new Caminhao(placa, marca, modelo));
            }
        }

        public void RemoverVeiculo(string placa)
        {
            //Remover veiculo e calcular o valor a pagar e se se nao tiver placa, falar que nao tem veiculo
            if (_veiculos.Any(x => x.Placa == placa))
            {
                Veiculo veiculo = _veiculos.First(x => x.Placa == placa);
                DateTime saida = DateTime.Now;
                TimeSpan tempo = saida - veiculo.Entrada;
                decimal valor = veiculo.PrecoInicial + (veiculo.PrecoPorHora * (decimal)tempo.Hours);
                _veiculos.Remove(veiculo);
                Console.WriteLine($"Veículo {veiculo.Placa} - {veiculo.Marca} - {veiculo.Modelo} removido. Valor a pagar: R$ {valor}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado");
            }


        }

        public string ListarVeiculosEstacionadosPorTipo(int tipoVeiculo)
        {
            string lista = "";
            foreach (Veiculo v in _veiculos)
            {
                switch (tipoVeiculo)
                {
                    case 1:
                        if (v is Automovel)
                        {
                            lista += v.ToString() + "\n";
                        }
                        break;
                    case 2:
                        if (v is Motocicleta)
                        {
                            lista += v.ToString() + "\n";
                        }
                        break;
                    case 3:
                        if (v is Caminhao)
                        {
                            lista += v.ToString() + "\n";
                        }
                        break;
                    case 4:
                        lista += v.ToString() + "\n";
                        break;
                    default:
                        break;
                }
            }
            return lista;
        }
        
    }
}