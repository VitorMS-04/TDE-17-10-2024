public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public abstract void Ligar();
    public void Desligar()
    {
        Console.WriteLine($"{Marca} {Modelo} Desligou.");
    }

    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

}