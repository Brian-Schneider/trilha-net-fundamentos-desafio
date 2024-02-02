using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Automovel : Veiculo
    {
        public Automovel(string placa, string marca, string modelo) : base(placa, marca, modelo)
        {
            PrecoInicial = 5;
            PrecoPorHora = 3;
        }

        public override string ToString()
        {
            return $"Tipo: Automóvel - Placa: {Placa} - Marca: {Marca} - Modelo: {Modelo} - Entrada: {Entrada}";
        }

    }
}