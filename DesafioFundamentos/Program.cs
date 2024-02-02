using DesafioFundamentos.Models;
using DesafioFundamentos.Controller;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

EstacionamentoController es = new EstacionamentoController();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento\n");


string opcao = string.Empty;
bool exibirMenu = true;

string placa = string.Empty;
int tipoVeiculo = 0;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Digite o tipo do veículo:");
            Console.WriteLine("1 - Automóvel");
            Console.WriteLine("2 - Motocicleta");
            Console.WriteLine("3 - Caminhão");

            tipoVeiculo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a placa do veículo:");
            placa = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a marca do veículo:");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do veículo:");
            string modelo = Console.ReadLine();

            es.AdicionarVeiculo(placa, marca, modelo, tipoVeiculo);
            break;

        case "2":
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine().ToUpper();
            es.RemoverVeiculo(placa);
            break;

        case "3":
            Console.WriteLine("Digite o tipo do veículo:");
            Console.WriteLine("1 - Automóvel");
            Console.WriteLine("2 - Motocicleta");
            Console.WriteLine("3 - Caminhão");
            Console.WriteLine("4 - Todos");

            tipoVeiculo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(es.ListarVeiculosEstacionadosPorTipo(tipoVeiculo));
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
