int opcion;

do
{

    Console.WriteLine("\n\n===== CALCULADORA =====");

    Console.WriteLine("Ingrese una de las siguiente opciones : \n1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Salir\n");

    opcion = int.Parse(Console.ReadLine());

    if (opcion != 5)
    {
        Console.Write("Ingrese el primer numero : ");

        int number_1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero : ");

        int number_2 = int.Parse(Console.ReadLine());

        int result;




        switch (opcion)
        {

            case 1:

                result = number_1 + number_2;

                Console.Write("El resultado es " + result);

                break;

            case 2:

                result = number_1 - number_2;

                Console.Write("El resultado es " + result);

                break;

            case 3:

                result = number_1 * number_2;

                Console.Write("El resultado es " + result);

                break;

            case 4:

                result = number_1 / number_2;

                Console.Write("El resultado es " + result);

                break;

        }

    }


} while (opcion != 5);


