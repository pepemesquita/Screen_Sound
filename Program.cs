
void ExibirLogo(){
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

}

void ExibirMensagemDeBoasVindas(){
    string mensagemBoasVindas = ("Boas Vindas ao Screen Sound!\n");    
    Console.WriteLine(mensagemBoasVindas);
   
}

void ExibirOpcoesDoMenu(){
    Console.WriteLine("Digite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica){
        case 1:
            RegistrarBanda();
            break;
        
        case 2:
            Console.WriteLine($"\nA opção escolhida foi {opcaoEscolhidaNumerica}");
            break;
        
        case 3:
            Console.WriteLine($"\nA opção escolhida foi {opcaoEscolhidaNumerica}");
            break;
        
        case 4:
            Console.WriteLine($"\nA opção escolhida foi {opcaoEscolhidaNumerica}");
            break;
        
        case -1:
            Console.WriteLine($"\nA opção escolhida foi {opcaoEscolhidaNumerica}");
            break;

        default:
            Console.WriteLine("\nOpção inválida!");
            break;
    }
}


void RegistrarBanda(){

}


ExibirLogo();
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();