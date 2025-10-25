Console.WriteLine("Bem-vindo à Calculadora!");
Console.WriteLine();
Console.WriteLine("Selecione uma operação");
Console.WriteLine();
Console.WriteLine("1. Adição");
Console.WriteLine("2. Subtração");
Console.WriteLine("3. Multiplicação");
Console.WriteLine("4. Divisão");
Console.WriteLine("5. Sair");
Console.WriteLine();

Console.Write("Digite o número da operação desejada: ");
string operacaoEscolhida = Console.ReadLine();

if (operacaoEscolhida == "5")
{
    Console.WriteLine("A calculadora será encerrada.");
}
else
{
    Console.Write("Digite o primeiro número: ");
    double numero1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double numero2 = double.Parse(Console.ReadLine());

    double resultado = 0;

    switch (operacaoEscolhida)
    {
        case "1":
            resultado = numero1 + numero2;
            break;
        case "2":
            resultado = numero1 - numero2;
            break;
        case "3":
            resultado = numero1 * numero2;
            break;
        case "4":
            resultado = numero1 / numero2;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Resultado: " + resultado);
}
