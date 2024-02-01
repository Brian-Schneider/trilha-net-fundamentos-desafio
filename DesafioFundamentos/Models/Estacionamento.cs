using System.Text;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal _precoInicial;
        private decimal _precoPorHora;
        private List<string> _veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
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

        public void AdicionarVeiculo()
        {
            // Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // IMPLEMENTADO!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (string.IsNullOrEmpty(placa) || placa.Length != 7)
            {
                Console.WriteLine("Digite uma placa válida");
                return;
            }
            _veiculos.Add(placa.ToUpper());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // IMPLEMENTADO!
            string placa = Console.ReadLine().ToUpper();

            if (string.IsNullOrEmpty(placa) || placa.Length != 7)
            {
                Console.WriteLine("Digite uma placa válida");
                return;
            }

            // Verifica se o veículo existe
            if (_veiculos.Any(x => x == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,               
                // IMPLEMENTADO!
                bool verificaValor = int.TryParse(Console.ReadLine(), out int horas);
                if(!verificaValor || horas < 0)
                {
                    Console.WriteLine("Digite um valor válido de horas");
                    return;
                }

                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal 
                // IMPLEMENTADO!
                decimal valorTotal = _precoInicial + _precoPorHora * horas; 

                // Remover a placa digitada da lista de veículos
                // // IMPLEMENTADO!
                _veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (_veiculos.Any())
            {
                StringBuilder sb = new StringBuilder("Os veículos estacionados são:\n");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var veiculo in _veiculos)
                {
                    sb.AppendLine(veiculo);
                }
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
