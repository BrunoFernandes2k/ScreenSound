using System.Xml;

string mensagemDeBoasVindas = "\nBem-vindo ao ScreedSound!";

//List<string> ListaDosArtistas = new List<string> {"Kendrick Lamar","Chris Brown","Tyler,The Creator"};

Dictionary<string, List<int>> ArtistasRegistrados = new Dictionary<string, List<int>>();
ArtistasRegistrados.Add("Kendrick Lamar", new List<int> { 10, 9, 8 });
ArtistasRegistrados.Add("Chris brown", new List<int>());
ArtistasRegistrados.Add("Tyler, The Creator", new List<int>());



void ExibirLogo()
{
Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▀▄   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █▄▀   ▄█ █▄█ █▄█ █░▀█ █▄▀");

Console.WriteLine(mensagemDeBoasVindas);

    Thread.Sleep(5000);
    Console.Clear();
}



void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDgite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para mostrar todos os artista");
    Console.WriteLine("Digite 3 para avaliar um artista");
    Console.WriteLine("Digite 4 para exibir a média do artista");
    Console.WriteLine("Digite -1 para sair!");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarArtista();
           break;
        case 2: MostrarArtistasRegistrados();
            break;
        case 3: AvaliarArtista();
            break;
        case 4: MediaDoArtista();
            break;
        case -1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;

        default: Console.WriteLine("Opção inválida");
            break;
    }
    
}

void RegistrarArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro dos artistas");
    Console.Write("Digite o nome do Artista que deseja registrar: ");
    string NomeDoArtista = Console.ReadLine()!;
    ArtistasRegistrados.Add(NomeDoArtista, new List<int>());
    Console.WriteLine($"O Artista {NomeDoArtista} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

        
}

void MostrarArtistasRegistrados()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todos os artistas registrados");

    foreach (string Artista in ArtistasRegistrados.Keys)
    {
        Console.WriteLine($"Artista: {Artista}");
    } 
    
    
   
    //for (int i = 0; i < ListaDosArtistas.Count; i++) 
    //{
        //Console.WriteLine($"Artista: {ListaDosArtistas[i]}");
    //}
     Console.WriteLine("\nDigite qualquer tecla para voltar ao menu prinicpal");
     Console.ReadKey();
     Console.Clear();
     ExibirOpcoesDoMenu();


}
void ExibirTituloDaOpcao(string titulo) 
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}

void AvaliarArtista()
{
    //Digita qual artista deseja avaliar
    //se o artista existir no dicionario >> atribuir uma nota
    //se não, volta ao menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar artista");
    Console.Write("Digite o nome do artista que deseja avaliar: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (ArtistasRegistrados.ContainsKey(nomeDoArtista)) 
    {
        Console.Write($"Qual a nota que o artista {nomeDoArtista} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        ArtistasRegistrados[nomeDoArtista].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrado com sucesso para o artista {nomeDoArtista}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nO Artista {nomeDoArtista} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para volta ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }


}

void MediaDoArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média do artista");
    Console.Write("Digite o nome do artista que deseja exibir a média: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (ArtistasRegistrados.ContainsKey(nomeDoArtista))
    {
        List<int> notasDosArtistas = ArtistasRegistrados[nomeDoArtista];
        Console.WriteLine($"\nA média do Artista {nomeDoArtista} é {notasDosArtistas.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDoArtista} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para volta ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
   
   

}

ExibirLogo();
ExibirOpcoesDoMenu();