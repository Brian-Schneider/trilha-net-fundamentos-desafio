using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Repository
{
    public interface EstacionamentoRepository
    {
        public void AdicionarVeiculo(string placa, string marca, string modelo, int tipoVeiculo);
        public void RemoverVeiculo(string placa);
        public string ListarVeiculosEstacionadosPorTipo(int tipoVeiculo);

    }
}