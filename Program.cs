string mensagemBoasVindas = "\nBoas Vindas ao Screen Sound!";    
List<string> listaDeBandas = new List<string>();

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
            Console.WriteLine($"\nA opção escolhida foi {opcaoEscolhida}");
            break;
        
        case 4:
            Console.WriteLine($"\nA opção escolhida foi {opcaoEscolhida}");
            break;
        
        case -1:
            Console.WriteLine($"\nA opção escolhida foi {opcaoEscolhida}");
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
    listaDeBandas.Add(nomeDaBanda);

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas(){

    Console.Clear();

    if (listaDeBandas.Count == 0){
        ExibirTituloDasOpcoes("Ainda não há banda registradas");
        Console.Write("Tecle 'Enter' para retornar ao menu: ");
        Console.ReadLine();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }else{
        ExibirTituloDasOpcoes("As bandas registradas são:");
        
        foreach (string banda in listaDeBandas!){
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("Tecle 'Enter' para retornar ao menu ");
        Console.ReadLine();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();