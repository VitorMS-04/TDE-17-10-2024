public class Carro : Veiculo, IAceleravel, IFreavel
{
    public override void Ligar()
    {
        Console.WriteLine($"{Marca} {Modelo} está ligado.");        
    }

    public void Acelerar()
    {
        Console.WriteLine($"{Marca} {Modelo} está acelerando.");
    }

    public void Frear()
    {
        Console.WriteLine($"{Marca} {Modelo} freou.");
    }
    public Carro(string marca, string modelo): base(marca,modelo)
    {

    }
}