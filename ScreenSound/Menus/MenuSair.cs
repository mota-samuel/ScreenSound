
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Bye Bye ;)");
    }
}
