

// Requisito 1: Nossa calculadora deve permitir a soma de dois numeros 
// Requisito 2: Nossa calculadora deve permitir a subtracao de dois numeros 
// Requisito 3: Nossa calculadora deve permitir a multiplicaçao de dois numeros
// Requisito 4: Nossa calculadora deve permitir a divisao de dois numeros
// Requisito 5: Nossa calculadora deve permitir que o usuário continue utilizando o sistema até decidir sair
// Requisito 6: Nossa calculadora deve dar a possibilidade de produizir a tabuada de um número informado
// Requisito 7: Nossa calculadora deve dar a possibilidade de visualizar o histórico de operações 


bool deveContinuar = true; //atribuiçao

while (deveContinuar == true) // condicao
{

    //Console.Clear();

    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Calculadora 2026!");
    Console.WriteLine("--------------------------------------------");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Multiplicacao");
    Console.WriteLine("4 - Divisao");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("S - Sair");
    

    Console.ReadLine();

    Console.WriteLine("Selecione uma opçao valida: ");
    string operacaoSelcionada = Console.ReadLine();

    if (operacaoSelcionada == "S")
    {
        deveContinuar = false;

        continue;
    }

    if (operacaoSelcionada == "5")
    {
        Console.WriteLine("Digite o numero que deseja gerar a tabuada: ");

        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        // para cada...
        // 1. contador/iteraçao
        // 2. enquanto for verdadeiro
        // 3. iteraçao da variavel contadora

        for (int contador = 1; contador <= 10; contador = contador +1)
        {
            int resultadoTabuada = numeroTabuada * contador;
            string operacaoTabuada = numeroTabuada + "x" + contador + " = ";


            Console.WriteLine(operacaoTabuada + resultadoTabuada);
            
        }
        Console.ReadLine();

        continue;

    }

    Console.Write("Digite o primeiro número: ");
    string? strPrimeiroNumero = Console.ReadLine();


    Console.Write("Digite o segundo número: ");
    string? strSegundoNumero = Console.ReadLine();

    Console.ReadLine();

    Console.WriteLine("O primeiro número digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O segundo número digitado foi: " + strSegundoNumero);

    Console.ReadLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);

    if (primeiroNumeroVazio || segundoNumeroVazio)
    {
        Console.WriteLine("Digite um número válido");
        Console.ReadLine();

        continue;
    }

    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);


    decimal resultado;

    switch (operacaoSelcionada)
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            break;

        case "2":
            resultado = primeiroNumero - segundoNumero;
            break;

        case "3":
            resultado = primeiroNumero * segundoNumero;
            break;

        case "4":
            if (segundoNumero == 0)
            {
                Console.WriteLine("Não é possível fazer uma divisão por zero. Tente novamente.");

                return; 
            }

            resultado = primeiroNumero / segundoNumero;
            break;

        default:
            Console.WriteLine("Selecione uma operação válida");
            Console.ReadLine();
            continue;

    }


    Console.WriteLine("A Operaçao dos dois numeros resulta em: " + resultado);



    Console.ReadLine();
    

}