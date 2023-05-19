int opcion;

do
{

    Console.WriteLine("\n\n===== CALCULADORA =====");

    Console.WriteLine("Ingrese una de las siguiente opciones : \n1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Salir\n6-Opciones Adicionales\n");

    opcion = int.Parse(Console.ReadLine());

    if (opcion == 6)
    {

        Console.WriteLine("\n\n===== OPCIONES AVANZADAS =====");

        Console.WriteLine("\n1-Valor Absoluto\n2-Potencia cuadrada\n3-Raiz cuadrada\n4-Seno\n5-Coseno\n6-Parte entera en tipo float\n");

        int opcion_2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el numero : ");

        int number_3 = int.Parse(Console.ReadLine());

        double result_2;

        switch (opcion_2)
        {

            case 1:

                if (number_3 < 0)
                {

                    number_3 = number_3 * -1;

                }

                Console.Write("El resultado es  " + number_3);

                break;

            case 2:

                number_3 = number_3 * number_3;

                Console.Write("El resultado es  " + number_3);

                break;

            case 3:

                result_2 = Math.Sqrt(number_3);

                Console.Write("El resultado es  " + result_2);

                break;

            case 4:

                result_2 = Math.Sin(number_3);

                Console.Write("El resultado es  " + result_2);

                break;

            case 5:

                result_2 = Math.Cos(number_3);

                Console.Write("El resultado es  " + result_2);

                break;

            case 6:

                Console.Write("No lo hice a este, hace otra operacion je ");

                break;


        }






    }

    if (opcion != 5 && opcion != 6)
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

Console.WriteLine("===== SACAR MAXIMO Y MINIMO =====");

Console.WriteLine("Ingrese el primero numero : ");

int number_5 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero : ");

int number_6 = int.Parse(Console.ReadLine());


if (number_5 > number_6)
{

    Console.WriteLine("El maximo es " + number_5 + " y el minimo es " + number_6);

}
else
{

    Console.WriteLine("El maximo es " + number_6 + " y el minimo es " + number_5);

}
