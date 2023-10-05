// Screen Sound
using System.ComponentModel.Design;

string mensagemDeBoasVindas = "boas vindas ao Screen Sound";
//List <string> listaDasBandas = new List<string>();

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
▒█▀▀▀█ █▀▀ █▀▀█ █▀▀ █▀▀ █▀▀▄  █▀▀ █▀▀█ █░░█ █▀▀▄ █▀▀▄ 
░▀▀▀▄▄ █░░ █▄▄▀ █▀▀ █▀▀ █░░█  ▀▀█ █░░█ █░░█ █░░█ █░░█ 
▒█▄▄▄█ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀ ▀░░▀  ▀▀▀ ▀▀▀▀ ░▀▀▀ ▀░░▀ ▀▀▀░ 
");
    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpçõesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda!");
    Console.WriteLine("Digite 4 para exibir a média de uma banda!");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite sua opção: ");
    string opçaoEscolhida = Console.ReadLine()!;
    int opçaoEscolhidaNumerica = int.Parse(opçaoEscolhida);
    switch (opçaoEscolhidaNumerica)
    {
        case 1: Registrarbanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMedia();
            break;
        case 5: Console.WriteLine("você escolheu a opção" + opçaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Fim do programa!" + opçaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("opção inválida");
            break;

    
    }


}

void Registrarbanda()
{
    Console.Clear();
    ExibirTitulo("Registro das bandas");
    
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpçõesDoMenu();
}


void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("exibindo bandas registradas");
    
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nclique qualquer tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçõesDoMenu();
}

void ExibirTitulo(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliar banda");
    Console.Write("Digite a banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep( 4000 );
        Console.Clear() ;
        ExibirOpçõesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçõesDoMenu();
    }

}

void ExibirMedia()
{
    Console.Clear();
    ExibirTitulo("Média das bandas");
    Console.Write("Digite o nome da banda que gostaria de avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey (nomeDaBanda))
    {
        double mediaDaBanda = bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"\nA media da banda {nomeDaBanda} é: {mediaDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpçõesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçõesDoMenu();

    }
}



ExibirMensagemDeBoasVindas();
ExibirOpçõesDoMenu();
