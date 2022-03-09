
var mouse = new Product(1, "Mouse Gamer", 34.99, EProductType.Product);
var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);
mouse.Name = "hiran";
Console.WriteLine(mouse.Id);
Console.WriteLine(mouse.Name);
Console.WriteLine(mouse.Price);
Console.WriteLine(mouse.Type);
Console.WriteLine((int)mouse.Price); //Aqui houve uma conversao explicita para mostrar o numero inteiro do enum.

struct Product
{
    //Abaixo tem a criacao de um metodo construtor, ou seja, metodo que recebe o mesmo nome do struct.

    public Product(int id, string name, double price, EProductType type)
    {
        Id = id;
        Name = name;
        Price = price;
        Type = type;
    }

    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public double PriceInDolar(double dolar) //Metodo
    {
        return Price * dolar;
    }
}

enum EProductType //Criacao do enum, fora do struct
{
    Product = 1,
    Service = 2
}