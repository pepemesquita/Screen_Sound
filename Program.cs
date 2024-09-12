
string mensagemBoasVindas = "\nBoas Vindas ao Screen Sound!";    

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo(){
    Console.WriteLine(@"    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

}

void ExibirMensagemDeBoasVindas(){
    Console.WriteLine(mensagemBoasVindas);
   
}

void ExibirOpcoesDoMenu(){
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida){
        case 1:
            RegistrarBanda();
            break;
        
        case 2:
            ExibirBandasRegistradas();
            break;
        
        case 3:
            AvaliarUmaBanda();
            break;
        
        case 4:
            ExibirMediaBanda();
            break;
        
        case -1:
            Console.WriteLine("Tchau!");
            break;

        default:
            Console.Write("\nOpção inválida! Tente novamente.");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
            break;
    }
}

void ExibirTituloDasOpcoes(string titulo){
    int quantidadeDeLetras = titulo.Length;
    string asteriscos =  string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}


void RegistrarBanda(){
    Console.Clear();
    ExibirTituloDasOpcoes("Registrar bandas");
    Console.Write("Digite o nome da banda que você quer registrar: ");
    
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas(){

    Console.Clear();

    if (bandasRegistradas.Count == 0){
        ExibirTituloDasOpcoes("Ainda não há banda registradas");
        Console.Write("Tecle 'Enter' para retornar ao menu: ");
        Console.ReadLine();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }else{
        ExibirTituloDasOpcoes("As bandas registradas são:");
        
        foreach (string banda in bandasRegistradas.Keys!){
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("Tecle 'Enter' para retornar ao menu ");
        Console.ReadLine();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void AvaliarUmaBanda(){
    Console.Clear();
    ExibirTituloDasOpcoes("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    String nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Que nota você avalia a banda {nomeDaBanda}? ");
        int notaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(notaBanda);
        Console.WriteLine($"\n A nota {notaBanda} foi atribuida a banda {nomeDaBanda} com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaBanda(){
    Console.Clear();
    ExibirTituloDasOpcoes("Media de Avaliação de Bandas");

    Console.Write("Digite o nome da banda para saber sua média de avaliação: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> avaliacoesBandas = bandasRegistradas[nomeDaBanda];

        Console.WriteLine($"A média de avaliação da banda {nomeDaBanda} é {avaliacoesBandas.Average()}");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Essa banda não existe!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();