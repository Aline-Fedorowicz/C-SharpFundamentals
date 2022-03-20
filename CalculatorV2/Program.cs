
Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Escolha a operação que deseja fazer:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");


    Console.WriteLine("--------");
    Console.WriteLine("Selecione uma opção:");
    string? parametro = Console.ReadLine();
    if (string.IsNullOrEmpty(parametro))
    {
        Console.WriteLine("Digite um valor válido!");
    }
    else
    {
        short res = short.Parse(parametro);
        Operacao(res);
    }

}

static void Operacao(short res)
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Segundo Valor:");
    float v2 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("");


    switch (res)
    {
        case 1: float resultadoSoma = v1 + v2; Console.WriteLine($"O resultado é: {v1} + {v2} = {resultadoSoma}"); break;
        case 2: float resultadoSubtracao = v1 - v2; Console.WriteLine($"O resultado é: {v1} - {v2} = {resultadoSubtracao}"); break;
        case 3: float resultadoDivisao = v1 / v2; Console.WriteLine($"O resultado é: {v1} / {v2} = {resultadoDivisao}"); break;
        case 4: float resultadoMultiplicacao = v1 * v2; Console.WriteLine($"O resultado é: {v1} * {v2} = {resultadoMultiplicacao}"); break;
        case 5: System.Environment.Exit(0); break;

        default: Menu(); break;
    }

    Console.ReadKey();
    Menu();



}