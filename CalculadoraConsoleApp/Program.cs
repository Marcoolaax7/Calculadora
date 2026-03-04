



// Requisito 1: Nossa calculadora deve permitir a soma de dois numeros 
// Requisito 2: Nossa calculadora deve permitir a subtracao de dois numeros 
// Requisito 3: Nossa calculadora deve permitir a multiplicaçao de dois numeros
// Requisito 4: Nossa calculadora deve permitir a divisao de dois numeros
// Requisito 5: Nossa calculadora deve permitir que o usuário continue utilizando o sistema até decidir sair

bool deveContinuar = true; //atribuiçao

while (deveContinuar == true) // condicao
{

    // Console.Clear();

    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Calculadora 2026!");
    Console.WriteLine("--------------------------------------------");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Multiplicacao");
    Console.WriteLine("4 - Divisao");
    Console.WriteLine("S - Sair");

    Console.ReadLine();

    Console.WriteLine("Selecione uma opçao valida: ");
    string operacaoSelcionada = Console.ReadLine();

    if (operacaoSelcionada == "S")
    {
        deveContinuar = false;

        continue;
    }

    Console.Write("Digite o primeiro número: ");
    string strPrimeiroNumero = Console.ReadLine();


    Console.Write("Digite o segundo número: ");
    string strSegundoNumero = Console.ReadLine();

    Console.ReadLine();

    Console.WriteLine("O primeiro número digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O segundo número digitado foi: " + strSegundoNumero);

    Console.ReadLine();

    // int = número inteiro
    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);
    int segundoNumero = Convert.ToInt32(strSegundoNumero);


    int resultado;

    if (operacaoSelcionada == "1")
    {
        resultado = primeiroNumero + segundoNumero;
    }


    else if (operacaoSelcionada == "2")
    {
        resultado = primeiroNumero - segundoNumero;
    }

    else if (operacaoSelcionada == "3")
    {
        resultado = primeiroNumero * segundoNumero;
    }


    else
    {
        if (segundoNumero == 0)
        {
            Console.WriteLine("Não é possivel fazer uma divisao por zero. Tente novamente.");

            return;
        }

        resultado = primeiroNumero / segundoNumero;

    }

    Console.WriteLine("A Operaçao dos dois numeros resulta em: " + resultado);



    Console.ReadLine();
    

}


