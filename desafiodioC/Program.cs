using desafio.models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

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
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
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





// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("MG");
// listaString.Add("RJ");


// Console.WriteLine("Percorrendo o array com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo o array com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
// }







// int[] arrayInteiros = new int [3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// int [] arrayInteirosDobrado = new int[ arrayInteiros.Length*2];
// Array.Copy(arrayInteiros,arrayInteirosDobrado, arrayInteiros.Length);


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);

// Console.WriteLine("Percorrendo o array com o FOR");

// for(int contador =0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº{contador} - {arrayInteiros[contador]}");
// }






// Console.WriteLine("Percorrendo o array com o FOREACH");

// int contadorForeach = 0;

// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº{contadorForeach} - {valor}");
//     contadorForeach++;
// }



// pessoa P = new pessoa();

// P.Name = "Luiz";
// P.Idade = 28;

// P.Apresentar();

