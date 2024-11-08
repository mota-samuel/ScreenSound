namespace ScreenSound.Modelos;

internal interface IAvaliacao
{
    void AdicionarNota(Avaliacao nota);
    double Media {  get; }
}
