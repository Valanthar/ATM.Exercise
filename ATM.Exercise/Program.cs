//ENTRADA
bool continuar = true;
int ValorSaque, ValorSobra;

while (continuar)
{
    Console.Clear();
    //NOTAS
    int notas50, notas20, notas10, notas5, notas1;

    //INTERACAO COM O USER
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n--- SISTEMA DE SAQUE AUTOMÁTICO ---\n");
    Console.ResetColor();

    Console.Write("--- QUANTO DESEJA SACAR?:");

    //leitura do valor informado
    if (!int.TryParse(Console.ReadLine(), out ValorSaque))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
        Console.WriteLine("\nPressione qualquer tecla para tentar novamente...");
        Console.ReadKey(); 
        continue; 
    }
    if (ValorSaque <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erro: O valor do saque deve ser maior que zero!");
        Console.ResetColor();
        Console.ReadKey();
        continue;
    }
    else
    {

        //PROCESSAMENTO

        //notas de 50
        notas50 = ValorSaque / 50;
        ValorSobra = ValorSaque % 50;
        //notas de 20
        notas20 = ValorSobra / 20;
        ValorSobra = ValorSobra % 20;
        //Notas 10
        notas10 = ValorSobra / 10;
        ValorSobra = ValorSobra % 10;
        //Notas 5
        notas5 = ValorSobra / 5;
        ValorSobra = ValorSobra % 5;
        //Notas 1
        notas1 = ValorSobra / 1;
        ValorSobra = ValorSobra % 1;

        //SAIDA
        if (ValorSobra == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saque realizado com sucesso");
            Console.WriteLine("Aqui esta o seu saque em:");

            if (notas50 > 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{notas50} notas de R$50");
            }
            if (notas20 > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{notas20} notas de R$20");
            }
            if (notas10 > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{notas10} notas de R$10");
            }
            if (notas5 > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{notas5} notas de R$5");
            }
            if (notas1 > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{notas1} notas de R$1");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Saque Invalido");

        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Deseja Realizar outro saque? (S/N)");
        string Resposta = Console.ReadLine().ToUpper();

        if (Resposta == "N")
        {
            continuar = false;
            Console.WriteLine("Obrigado por usar o ATM. Até logo!");
        }
    }
}
Console.ReadKey();