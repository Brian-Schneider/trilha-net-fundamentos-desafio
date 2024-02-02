using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public abstract class Veiculo
    {
        private decimal _precoInicial;
        private decimal _precoPorHora;
        private string _placa;
        private string _marca;
        private string _modelo;
        private DateTime _entrada;

        public Veiculo(string placa, string marca, string modelo)
        {
            _placa = placa;
            _marca = marca;
            _modelo = modelo;
            _entrada = DateTime.Now;
        }

        public decimal PrecoInicial
        {
            get { return _precoInicial; }
            set { _precoInicial = value; }
        }

        public decimal PrecoPorHora
        {
            get { return _precoPorHora; }
            set { _precoPorHora = value; }
        }

        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public DateTime Entrada
        {
            get { return _entrada; }
            set { _entrada = value; }
        }

        public decimal CalcularValor()
        {
            var horas = (DateTime.Now - _entrada).TotalHours;
            return _precoInicial + (_precoPorHora * (decimal)horas);
        }

    }
}