public class Bicicleta : Veiculo, IAceleravel
{
    public override void Ligar()
    {
        Console.WriteLine($"{Marca} {Modelo} está ligada.");        
    }

    public void Acelerar()
    {
        Console.WriteLine($"{Marca} {Modelo} está acelerando.");
    }

    public Bicicleta(string marca, string modelo): base (marca,modelo)
    {

    }
}