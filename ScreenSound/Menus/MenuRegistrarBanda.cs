using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    internal override async void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        //aplicacao da API do ChatGPT
        //Acessando a API_Key
        var client = new OpenAIAPI("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");
        //Criando Conversa
        var chat = client.Chat.CreateConversation();
        //Fazendo a pergunta ao Chat GPT
        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 paragrafo simples, de maneira informal");
        //criando uma variavel para armazenar a resposta
        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        //Imprimindo a resposta
        banda.Resumo = resposta;


        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
