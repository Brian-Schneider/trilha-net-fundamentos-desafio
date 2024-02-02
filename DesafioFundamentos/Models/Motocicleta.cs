using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Motocicleta : Veiculo
    {
        public Motocicleta(string placa, string marca, string modelo) : base(placa, marca, modelo)
        {
            PrecoInicial = 3;
            PrecoPorHora = 2;
        }

        public override string ToString()
        {
            return $"Tipo: Motocicleta - Placa: {Placa} - Marca: {Marca} - Modelo: {Modelo} - Entrada: {Entrada}";
        }
    }
}