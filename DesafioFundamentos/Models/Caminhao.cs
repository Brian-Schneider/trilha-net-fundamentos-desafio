using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Caminhao : Veiculo
    {
        public Caminhao(string placa, string marca, string modelo) : base(placa, marca, modelo)
        {
            PrecoInicial = 10;
            PrecoPorHora = 5;
        }

        public override string ToString()
        {
            return $"Tipo: Caminhão - Placa: {Placa} - Marca: {Marca} - Modelo: {Modelo} - Entrada: {Entrada}";
        }
    }
}